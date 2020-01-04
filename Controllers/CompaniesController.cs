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
    public class CompaniesController : Controller
    {
        private readonly GCSContext _context;

        public CompaniesController(GCSContext context)
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

        // GET: Companies
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }

            ViewBag.Admin = User.Claims.ToList()[2].Value;

            List<Company> companies = await _context.Companies
                .FromSql(@"
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
  FROM [company]
  where deleted_on is null").ToListAsync();

            return View(companies);
        }

        // GET: Companies/Details/5
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

            var company = await _context.Companies
                .FromSql(@"
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
  FROM [company]
  where deleted_on is null and id={0}", id)
                .FirstOrDefaultAsync(m => m.Id == id);


            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Companies/Create
        public async Task<IActionResult> Create()
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            ViewBag.RevenueList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Revenue").ToListAsync();
            ViewBag.CompTypeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Type-Company").ToListAsync();
            ViewBag.StageList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Stage").ToListAsync();
            ViewBag.EmployeeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Employees").ToListAsync();
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address1,Address2,City,State,Zip,Country,Email,Website,Phone,Vision,Mission,Value,Type,Revenue_band,Employee_band,Stage")] Company company)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (ModelState.IsValid)
            {
                await _context.Database.ExecuteSqlCommandAsync(@"
INSERT INTO [company]
           ([name]
           ,[address1]
            ,[address2]
            ,[city]
            ,[state]
            ,[zip]
            ,[country]
           ,[email]
           ,[website]
           ,[phone]
           ,[inserted_on]
           ,[inserted_by]
           ,[vision]
           ,[mission]
           ,[value]
           ,[type]
           ,[revenue_band]
           ,[employee_band]
           ,[stage])
     VALUES
           (@name
           ,@address1
            ,@address2
            ,@city
            ,@state
            ,@zip
            ,@country
           ,@email
           ,@website
           ,@phone
           ,GETDATE()
           ,@inserted_by
           ,@vision
           ,@mission
           ,@value
           ,@type
           ,@revenue_band
           ,@employee_band
           ,@stage)",
             new SqlParameter("@name", (object)company.Name ?? DBNull.Value),
             new SqlParameter("@address1", (object)company.Address1 ?? DBNull.Value),
             new SqlParameter("@address2", (object)company.Address2 ?? DBNull.Value),
             new SqlParameter("@city", (object)company.City ?? DBNull.Value),
             new SqlParameter("@state", (object)company.State ?? DBNull.Value),
             new SqlParameter("@zip", (object)company.Zip ?? DBNull.Value),
             new SqlParameter("@country", (object)company.Country ?? DBNull.Value),
             new SqlParameter("@email", (object)company.Email ?? DBNull.Value),
             new SqlParameter("@website", (object)company.Website ?? DBNull.Value),
             new SqlParameter("@phone", (object)company.Phone ?? DBNull.Value),
             new SqlParameter("@inserted_by", (object)User.Identity.Name ?? DBNull.Value),
             new SqlParameter("@vision", (object)company.Vision ?? DBNull.Value),
             new SqlParameter("@mission", (object)company.Mission ?? DBNull.Value),
             new SqlParameter("@value", (object)company.Value ?? DBNull.Value),
             new SqlParameter("@type", (object)company.Type ?? DBNull.Value),
             new SqlParameter("@revenue_band", (object)company.Revenue_band ?? DBNull.Value),
             new SqlParameter("@employee_band", (object)company.Employee_band ?? DBNull.Value),
             new SqlParameter("@stage", (object)company.Stage ?? DBNull.Value)
             );
                //_context.Add(company);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            ViewBag.RevenueList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Revenue").ToListAsync();
            ViewBag.CompTypeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Type-Company").ToListAsync();
            ViewBag.StageList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Stage").ToListAsync();
            ViewBag.EmployeeList = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Company-Employees").ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            //var company = await _context.Companies.FindAsync(id);
            var company = await _context.Companies
                .FromSql(@"
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
  FROM [company]
  where deleted_on is null and id={0}", id)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address1,Address2,City,State,Zip,Country,Email,Website,Phone,Vision,Mission,Value,Type,Revenue_band,Employee_band,Stage")] Company company)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (id != company.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(company);
                    //await _context.SaveChangesAsync();
                    await _context.Database.ExecuteSqlCommandAsync(@"update [company]
   SET [name] = @name
      ,[address1] = @address1
    ,[address2] = @address2
    ,[city] = @city
    ,[state] = @state
    ,[zip] = @zip
    ,[country] = @country
      ,[email] = @email
      ,[website] = @website
      ,[phone] = @phone
      ,[updated_on] = GETDATE()
      ,[updated_by] = @updated_by
      ,[vision] = @vision
      ,[mission] = @mission
      ,[value] = @value
      ,[type] = @type
      ,[revenue_band] = @revenue_band
      ,[employee_band] = @employee_band
      ,[stage] = @stage
 WHERE deleted_on is null and id=@id",
             new SqlParameter("@name", (object)company.Name ?? DBNull.Value),
             new SqlParameter("@address1", (object)company.Address1 ?? DBNull.Value),
             new SqlParameter("@address2", (object)company.Address2 ?? DBNull.Value),
             new SqlParameter("@city", (object)company.City ?? DBNull.Value),
             new SqlParameter("@state", (object)company.State ?? DBNull.Value),
             new SqlParameter("@zip", (object)company.Zip ?? DBNull.Value),
             new SqlParameter("@country", (object)company.Country ?? DBNull.Value),
             new SqlParameter("@email", (object)company.Email ?? DBNull.Value),
             new SqlParameter("@website", (object)company.Website ?? DBNull.Value),
             new SqlParameter("@phone", (object)company.Phone ?? DBNull.Value),
             new SqlParameter("@updated_by", (object)User.Identity.Name ?? DBNull.Value),
             new SqlParameter("@vision", (object)company.Vision ?? DBNull.Value),
             new SqlParameter("@mission", (object)company.Mission ?? DBNull.Value),
             new SqlParameter("@value", (object)company.Value ?? DBNull.Value),
             new SqlParameter("@type", (object)company.Type ?? DBNull.Value),
             new SqlParameter("@revenue_band", (object)company.Revenue_band ?? DBNull.Value),
             new SqlParameter("@employee_band", (object)company.Employee_band ?? DBNull.Value),
             new SqlParameter("@stage", (object)company.Stage ?? DBNull.Value),
             new SqlParameter("@id", id)
             );
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.Id))
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
            return View(company);
        }

        // GET: Companies/Delete/5
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

            //var company = await _context.Companies
            //    .FirstOrDefaultAsync(m => m.Id == id);
            var company = await _context.Companies
                .FromSql(@"
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
  FROM [company]
  where deleted_on is null and id={0}", id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            //var company = await _context.Companies.FindAsync(id);
            //_context.Companies.Remove(company);
            //await _context.SaveChangesAsync();
            await _context.Database.ExecuteSqlCommandAsync(@"update [company]
set deleted_by=@deleted_by, deleted_on=GETDATE()
where deleted_on is null and id=@id",
             new SqlParameter("@deleted_by", User.Identity.Name),
             new SqlParameter("@id", id)
             );
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }
    }
}
