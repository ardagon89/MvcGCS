using GCS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // GET: Companies
        public async Task<IActionResult> Index()
        {
            List<Company> companies = await _context.Companies
                .FromSql(@"
        SELECT [id]
      ,[name]
      ,[address]
      ,[email]
      ,[website]
      ,[phone]
      ,[vision]
      ,[mission]
      ,[value]
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
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FromSql(@"
        SELECT [id]
      ,[name]
      ,[address]
      ,[email]
      ,[website]
      ,[phone]
      ,[vision]
      ,[mission]
      ,[value]
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,Email,Website,Phone,Vision,Mission,Value,Type,Revenue_band,Employee_band,Stage")] Company company)
        {
            if (ModelState.IsValid)
            {
                await _context.Database.ExecuteSqlCommandAsync(@"
INSERT INTO [company]
           ([name]
           ,[address]
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
           ,@address
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
             new SqlParameter("@address", (object)company.Address ?? DBNull.Value),
             new SqlParameter("@email", (object)company.Email ?? DBNull.Value),
             new SqlParameter("@website", (object)company.Website ?? DBNull.Value),
             new SqlParameter("@phone", (object)company.Phone ?? DBNull.Value),
             new SqlParameter("@inserted_by", (object)1 ?? DBNull.Value),
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
            if (id == null)
            {
                return NotFound();
            }

            //var company = await _context.Companies.FindAsync(id);
            var company = await _context.Companies
                .FromSql(@"
        SELECT [id]
      ,[name]
      ,[address]
      ,[email]
      ,[website]
      ,[phone]
      ,[vision]
      ,[mission]
      ,[value]
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,Email,Website,Phone,Vision,Mission,Value,Type,Revenue_band,Employee_band,Stage")] Company company)
        {
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
      ,[address] = @address
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
             new SqlParameter("@address", (object)company.Address ?? DBNull.Value),
             new SqlParameter("@email", (object)company.Email ?? DBNull.Value),
             new SqlParameter("@website", (object)company.Website ?? DBNull.Value),
             new SqlParameter("@phone", (object)company.Phone ?? DBNull.Value),
             new SqlParameter("@updated_by", (object)1 ?? DBNull.Value),
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
      ,[address]
      ,[email]
      ,[website]
      ,[phone]
      ,[vision]
      ,[mission]
      ,[value]
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
            //var company = await _context.Companies.FindAsync(id);
            //_context.Companies.Remove(company);
            //await _context.SaveChangesAsync();
            await _context.Database.ExecuteSqlCommandAsync(@"update [company]
set deleted_by=@deleted_by, deleted_on=GETDATE()
where deleted_on is null and id=@id",
             new SqlParameter("@deleted_by", 1),
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
