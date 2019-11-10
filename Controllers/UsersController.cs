using GCS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User
                .FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address]
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
where deleted_on is null").ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address]
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

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company_id,Fname,Lname,Address,Phone,Email,Password,Is_admin,Gender,Race,Role,Company_length,Role_length,Inserted_on,Inserted_by,Updated_on,Updated_by,Deleted_on,Deleted_by")] User user)
        {
            if (ModelState.IsValid)
            {
                await _context.Database.ExecuteSqlCommandAsync(@"
INSERT INTO [user]
           ([company_id]
           ,[fname]
           ,[lname]
           ,[address]
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
           ,@address
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
             new SqlParameter("@address", (object)user.Address ?? DBNull.Value),
             new SqlParameter("@phone", (object)user.Phone ?? DBNull.Value),
             new SqlParameter("@email", (object)user.Email ?? DBNull.Value),
             new SqlParameter("@password", (object)user.Password ?? DBNull.Value),
             new SqlParameter("@is_admin", (object)user.Is_admin ?? DBNull.Value),
             new SqlParameter("@gender", (object)user.Gender ?? DBNull.Value),
             new SqlParameter("@race", (object)user.Race ?? DBNull.Value),
             new SqlParameter("@role", (object)user.Role ?? DBNull.Value),
             new SqlParameter("@company_length", (object)user.Company_length ?? DBNull.Value),
             new SqlParameter("@role_length", (object)user.Role_length ?? DBNull.Value),
             new SqlParameter("@inserted_by", 1)
             );
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address]
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
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company_id,Fname,Lname,Address,Phone,Email,Password,Is_admin,Gender,Race,Role,Company_length,Role_length,Inserted_on,Inserted_by,Updated_on,Updated_by,Deleted_on,Deleted_by")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Database.ExecuteSqlCommandAsync(@"update [user]
set company_id=@company_id, fname=@fname, lname=@lname, address=@address, phone=@phone, email=@email, password=@password, 
is_admin=@is_admin, gender=@gender, race=@race, role=@role, company_length=@company_length, role_length=@role_length, 
updated_by=@updated_by, updated_on=GETDATE()
where deleted_on is null and id=@id",
             new SqlParameter("@company_id", (object)user.Company_id ?? DBNull.Value),
             new SqlParameter("@fname", (object)user.Fname ?? DBNull.Value),
             new SqlParameter("@lname", (object)user.Lname ?? DBNull.Value),
             new SqlParameter("@address", (object)user.Address ?? DBNull.Value),
             new SqlParameter("@phone", (object)user.Phone ?? DBNull.Value),
             new SqlParameter("@email", (object)user.Email ?? DBNull.Value),
             new SqlParameter("@password", (object)user.Password ?? DBNull.Value),
             new SqlParameter("@is_admin", (object)user.Is_admin ?? DBNull.Value),
             new SqlParameter("@gender", (object)user.Gender ?? DBNull.Value),
             new SqlParameter("@race", (object)user.Race ?? DBNull.Value),
             new SqlParameter("@role", (object)user.Role ?? DBNull.Value),
             new SqlParameter("@company_length", (object)user.Company_length ?? DBNull.Value),
             new SqlParameter("@role_length", (object)user.Role_length ?? DBNull.Value),
             new SqlParameter("@updated_by", 1),
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
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FromSql(@"
        SELECT [id]
      ,COALESCE([company_id], 0) company_id
      ,[fname]
      ,[lname]
      ,[address]
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

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var user = await _context.User.FindAsync(id);

            await _context.Database.ExecuteSqlCommandAsync(@"update [user]
set deleted_by=@deleted_by, deleted_on=GETDATE()
where deleted_on is null and id=@id",
             new SqlParameter("@deleted_by", 1),
             new SqlParameter("@id", id)
             );

            return RedirectToAction(nameof(Index));
        }

        //Has to be changed to only select users where deleted_on is null
        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
