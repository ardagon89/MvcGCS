using GCS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GCS.Controllers
{
    public class UsersController : Controller
    {
        private readonly GCSContext _context;

        public UsersController(GCSContext context)
        {
            _context = context;

        }

        public Boolean IsLoggedIn()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return false;
            }
            return true;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {

            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }

            ViewBag.Admin = User.Claims.ToList()[2].Value;

            List<User> users = await _context.Users
                .FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address1]
      ,[address2]
      ,[city]
      ,[state]
      ,[zip]
      ,[country]
      ,[phone]
      ,[email]
      ,[password]
      ,COALESCE([is_admin], 'false') is_admin
      ,[gender]
      ,[race]
      ,[role]
      ,[company_length]
      ,[role_length]
FROM [user]
where deleted_on is null and ({0} = 'True' or  id={1})", User.Claims.ToList()[2].Value, User.Identity.Name).ToListAsync();

            List<Company> companies = await _context.Companies.ToListAsync();

            var innerJoin = users.Join(// outer sequence 
                      companies,  // inner sequence 
                      user => user.Company_id,    // outerKeySelector
                      company => company.Id,  // innerKeySelector
                      (user, company) => new UserCompanyViewModel // result selector
                      {
                          user = user,
                          company = company
                      });

            return View(innerJoin);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address1]
      ,[address2]
      ,[city]
      ,[state]
      ,[zip]
      ,[country]
      ,[phone]
      ,[email]
      ,[password]
      ,COALESCE([is_admin], 'false') is_admin
      ,[gender]
      ,[race]
      ,[role]
      ,[company_length]
      ,[role_length]
FROM [user] 
where deleted_on is null and id={0}", id).FirstOrDefaultAsync<User>();

            if (user == null)
            {
                return NotFound();
            }
            var company = await _context.Companies.FirstOrDefaultAsync(m => m.Id == user.Company_id);

            UserCompanyViewModel uc = new UserCompanyViewModel();
            uc.user = user;
            uc.company = company;

            return View(uc);
        }

        // GET: Users/Create
        public async Task<IActionResult> Create()
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            List<Company> companylist = new List<Company>();
            companylist = (await _context.Companies.FromSql(@"
        SELECT [id]
      ,[name]
      ,[address1]
        ,[address2]
        ,[city]
        ,[state]
        ,[zip]
        ,[country]
      ,[email]
      ,[website]
      ,[phone]
      ,[vision]
      ,[mission]
      ,[value]
      ,[outcome]
      ,[strategy]
      ,[type]
      ,[revenue_band]
      ,[employee_band]
      ,[stage]
      ,[keycontact]
  FROM [company]
  where deleted_on is null
order by [name]").ToListAsync());
            ViewBag.CompanyList = companylist;
            ViewBag.GenderList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Gender").ToListAsync();
            ViewBag.RaceList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Race").ToListAsync();
            ViewBag.RoleList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Role").ToListAsync();
            ViewBag.CompanyTimeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Time-Company").ToListAsync();
            ViewBag.CompanyTypeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Type").ToListAsync();
            ViewBag.RoleTimeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Time-Role").ToListAsync();
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company_id,Fname,Lname,Address1,Address2,City,State,Zip,Country,Phone,Email,Password,Is_admin,Gender,Race,Role,Company_length,Role_length,Inserted_on,Inserted_by,Updated_on,Updated_by,Deleted_on,Deleted_by")] User user)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (ModelState.IsValid)
            {
                await _context.Database.ExecuteSqlCommandAsync(@"
INSERT INTO [user]
           ([company_id]
           ,[fname]
           ,[lname]
           ,[address1]
          ,[address2]
          ,[city]
          ,[state]
          ,[zip]
          ,[country]
           ,[phone]
           ,[email]
           ,[password]
           ,[is_admin]
           ,[gender]
           ,[race]
           ,[role]
           ,[company_length]
           ,[role_length]
           ,[inserted_on]
           ,[inserted_by])
     VALUES
           (@company_id
           ,@fname
           ,@lname
           ,@address1
            ,@address2
            ,@city
            ,@state
            ,@zip
            ,@country
           ,@phone
           ,@email
           ,@password
           ,@is_admin
           ,@gender
           ,@race
           ,@role
           ,@company_length
           ,@role_length
           ,GETDATE()
           ,@inserted_by)",
             new SqlParameter("@company_id", (object)user.Company_id ?? DBNull.Value),
             new SqlParameter("@fname", (object)user.Fname ?? DBNull.Value),
             new SqlParameter("@lname", (object)user.Lname ?? DBNull.Value),
             new SqlParameter("@address1", (object)user.Address1 ?? DBNull.Value),
             new SqlParameter("@address2", (object)user.Address2 ?? DBNull.Value),
             new SqlParameter("@city", (object)user.City ?? DBNull.Value),
             new SqlParameter("@state", (object)user.State ?? DBNull.Value),
             new SqlParameter("@zip", (object)user.Zip ?? DBNull.Value),
             new SqlParameter("@country", (object)user.Country ?? DBNull.Value),
             new SqlParameter("@phone", (object)user.Phone ?? DBNull.Value),
             new SqlParameter("@email", (object)user.Email ?? DBNull.Value),
             new SqlParameter("@password", (object)user.Password ?? DBNull.Value),
             new SqlParameter("@is_admin", (object)user.Is_admin ?? DBNull.Value),
             new SqlParameter("@gender", (object)user.Gender ?? DBNull.Value),
             new SqlParameter("@race", (object)user.Race ?? DBNull.Value),
             new SqlParameter("@role", (object)user.Role ?? DBNull.Value),
             new SqlParameter("@company_length", (object)user.Company_length ?? DBNull.Value),
             new SqlParameter("@role_length", (object)user.Role_length ?? DBNull.Value),
             new SqlParameter("@inserted_by", User.Identity.Name)
             );
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address1]
      ,[address2]
      ,[city]
      ,[state]
      ,[zip]
      ,[country]
      ,[phone]
      ,[email]
      ,[password]
      ,COALESCE([is_admin], 'false') is_admin
      ,[gender]
      ,[race]
      ,[role]
      ,[company_length]
      ,[role_length]
FROM [user] where deleted_on is null and id={0}", id).FirstOrDefaultAsync<User>();

            List<Company> companylist = new List<Company>();
            companylist = (await _context.Companies.FromSql(@"
        SELECT [id]
      ,[name]
      ,[address1]
        ,[address2]
        ,[city]
        ,[state]
        ,[zip]
        ,[country]
      ,[email]
      ,[website]
      ,[phone]
      ,[vision]
      ,[mission]
      ,[value]
      ,[outcome]
      ,[strategy]
      ,[type]
      ,[revenue_band]
      ,[employee_band]
      ,[stage]
      ,[keycontact]
  FROM [company]
  where deleted_on is null
order by [name]").ToListAsync());
            ViewBag.CompanyList = companylist;
            ViewBag.GenderList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Gender").ToListAsync();
            ViewBag.RaceList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Race").ToListAsync();
            ViewBag.RoleList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Role").ToListAsync();
            ViewBag.CompanyTimeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Time-Company").ToListAsync();
            ViewBag.CompanyTypeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Type").ToListAsync();
            ViewBag.RoleTimeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Time-Role").ToListAsync();

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company_id,Fname,Lname,Address1,Address2,City,State,Zip,Country,Phone,Email,Password,Is_admin,Gender,Race,Role,Company_length,Role_length,Inserted_on,Inserted_by,Updated_on,Updated_by,Deleted_on,Deleted_by")] User user)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Database.ExecuteSqlCommandAsync(@"update [user]
set company_id=@company_id, fname=@fname, lname=@lname, address1=@address1, address2=@address2
            ,city=@city
            ,state=@state
            ,zip=@zip
            ,country=@country ,phone=@phone, email=@email, password=@password, 
is_admin=@is_admin, gender=@gender, race=@race, role=@role, company_length=@company_length, role_length=@role_length, 
updated_by=@updated_by, updated_on=GETDATE()
where deleted_on is null and id=@id",
             new SqlParameter("@company_id", (object)user.Company_id ?? DBNull.Value),
             new SqlParameter("@fname", (object)user.Fname ?? DBNull.Value),
             new SqlParameter("@lname", (object)user.Lname ?? DBNull.Value),
             new SqlParameter("@address1", (object)user.Address1 ?? DBNull.Value),
             new SqlParameter("@address2", (object)user.Address2 ?? DBNull.Value),
             new SqlParameter("@city", (object)user.City ?? DBNull.Value),
             new SqlParameter("@state", (object)user.State ?? DBNull.Value),
             new SqlParameter("@zip", (object)user.Zip ?? DBNull.Value),
             new SqlParameter("@country", (object)user.Country ?? DBNull.Value),
             new SqlParameter("@phone", (object)user.Phone ?? DBNull.Value),
             new SqlParameter("@email", (object)user.Email ?? DBNull.Value),
             new SqlParameter("@password", (object)user.Password ?? DBNull.Value),
             new SqlParameter("@is_admin", (object)user.Is_admin ?? DBNull.Value),
             new SqlParameter("@gender", (object)user.Gender ?? DBNull.Value),
             new SqlParameter("@race", (object)user.Race ?? DBNull.Value),
             new SqlParameter("@role", (object)user.Role ?? DBNull.Value),
             new SqlParameter("@company_length", (object)user.Company_length ?? DBNull.Value),
             new SqlParameter("@role_length", (object)user.Role_length ?? DBNull.Value),
             new SqlParameter("@updated_by", User.Identity.Name),
             new SqlParameter("@id", id)
             );

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address1]
      ,[address2]
      ,[city]
      ,[state]
      ,[zip]
      ,[country]
      ,[phone]
      ,[email]
      ,[password]
      ,COALESCE([is_admin], 'false') is_admin
      ,[gender]
      ,[race]
      ,[role]
      ,[company_length]
      ,[role_length]
FROM [user] where deleted_on is null and id={0}", id).FirstOrDefaultAsync<User>();

            if (user == null)
            {
                return NotFound();
            }
            var company = await _context.Companies.FirstOrDefaultAsync(m => m.Id == user.Company_id);

            UserCompanyViewModel uc = new UserCompanyViewModel();
            uc.user = user;
            uc.company = company;

            return View(uc);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            //var user = await _context.User.FindAsync(id);

            await _context.Database.ExecuteSqlCommandAsync(@"update [user]
set deleted_by=@deleted_by, deleted_on=GETDATE()
where deleted_on is null and id=@id",
             new SqlParameter("@deleted_by", User.Identity.Name),
             new SqlParameter("@id", id)
             );

            return RedirectToAction(nameof(Index));
        }

        //Has to be changed to only select users where deleted_on is null
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}