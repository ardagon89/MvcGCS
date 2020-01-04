using GCS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GCS
{
    public class AssessmentsController : Controller
    {
        private readonly GCSContext _context;

        public AssessmentsController(GCSContext context)
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

        // GET: Assessments
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }

            ViewBag.Admin = User.Claims.ToList()[2].Value;
            List<Assessment> assessments;
            if (ViewBag.Admin == "False")
            {
                 assessments = await _context.Assessment
                    .FromSql(@"
SELECT TOP (1000) [id]
      ,[company_id]
      ,[assessment_date]
      ,[Vision_agreement]
      ,[Core_values_agreement]
      ,[Mission_statement_agreement]
      ,[Vision_outcome_agreement]
      ,[Competitive_strategy_agreement]
      ,[Company_composite_score]
      ,[Strat_people_score]
      ,[Strat_resources_score]
      ,[Strat_processes_score]
      ,[Strat_culture_score]
      ,[Strat_composite_score]
      ,[Stake_people_score]
      ,[Stake_resources_score]
      ,[Stake_processes_score]
      ,[Stake_culture_score]
      ,[Stake_composite_score]
      ,[Oper_people_score]
      ,[Oper_resources_score]
      ,[Oper_processes_score]
      ,[Oper_culture_score]
      ,[Oper_composite_score]
      ,[Risk_people_score]
      ,[Risk_resources_score]
      ,[Risk_processes_score]
      ,[Risk_culture_score]
      ,[Risk_composite_score]
  FROM [GovCapSurvey_DB].[dbo].[assessment]
  where inserted_by = {0} and deleted_on is null
  order by assessment_date desc", User.Identity.Name)
                    .ToListAsync();
            }
            else
            {
                 assessments = await _context.Assessment.OrderByDescending(a => a.Assessment_date).ToListAsync();
            }

            List<Company> companies = await _context.Companies.ToListAsync();

            var innerJoin = assessments.Join(// outer sequence 
                      companies,  // inner sequence 
                      assessment => assessment.Company_id,    // outerKeySelector
                      company => company.Id,  // innerKeySelector
                      (assessment, company) => new AssessmentCompanyViewModel // result selector
                      {
                          assessment = assessment,
                          company = company
                      });

            return View(innerJoin);
        }

        // GET: Assessments/Details/5
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

            var assessment = await _context.Assessment
                .FirstOrDefaultAsync(m => m.Id == id);

            ViewBag.company = await _context.Companies
                .FirstOrDefaultAsync(c => c.Id == assessment.Company_id);

            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        // GET: Assessments/ChangeDate
        public async Task<IActionResult> ChangeDate(string value)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;

            ViewBag.dropdownlist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Agreement").ToListAsync();

            ViewBag.peopleratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-People").ToListAsync();

            ViewBag.resourcesratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Resources").ToListAsync();

            ViewBag.processesratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Processes").ToListAsync();

            ViewBag.cultureratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Culture").ToListAsync();

            User user = await _context.Users.FirstOrDefaultAsync(u => u.Id == int.Parse(User.Identity.Name));

            ViewBag.company = await _context.Companies.Where(c => c.Id == user.Company_id).ToListAsync();

            ViewBag.outcomes = await _context.Outcome
                .Where(m => m.Company_id == user.Company_id)
                .OrderByDescending(n => n.Assessment_date).ToListAsync();


            ViewBag.outcome = ViewBag.outcomes[0];
            foreach (Outcome o in ViewBag.outcomes)
            {
                if(o.Assessment_date == DateTime.Parse(value))
                {
                    ViewBag.outcome = o;
                }
            }

            return View("Create");
        }

        // GET: Assessments/Create
        public async Task<IActionResult> Create(string value)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;

            ViewBag.dropdownlist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Agreement").ToListAsync();

            ViewBag.peopleratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-People").ToListAsync();

            ViewBag.resourcesratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Resources").ToListAsync();

            ViewBag.processesratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Processes").ToListAsync();

            ViewBag.cultureratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Culture").ToListAsync();

            User user =await _context.Users.FirstOrDefaultAsync(u => u.Id == int.Parse(User.Identity.Name));

            ViewBag.company = await _context.Companies.Where(c => c.Id == user.Company_id).ToListAsync();

            if(value == null)
            {
                ViewBag.outcomes = await _context.Outcome
                    /*.Where(m => m.Company_id == user.Company_id)*/
                    .FromSql(@"
SELECT TOP (1000) [id]
      ,[company_id]
      ,[assessment_date]
      ,[strat_fo_outcome_val_1]
      ,[strat_fo_outcome_desc_1]
      ,[strat_fo_outcome_val_2]
      ,[strat_fo_outcome_desc_2]
      ,[strat_fo_outcome_val_3]
      ,[strat_fo_outcome_desc_3]
      ,[strat_fo_outcome_val_4]
      ,[strat_fo_outcome_desc_4]
      ,[strat_fo_outcome_val_5]
      ,[strat_fo_outcome_desc_5]
      ,[strat_ro_outcome_val_1]
      ,[strat_ro_outcome_desc_1]
      ,[strat_ro_outcome_val_2]
      ,[strat_ro_outcome_desc_2]
      ,[strat_ro_outcome_val_3]
      ,[strat_ro_outcome_desc_3]
      ,[strat_ro_outcome_val_4]
      ,[strat_ro_outcome_desc_4]
      ,[strat_ro_outcome_val_5]
      ,[strat_ro_outcome_desc_5]
      ,[stake_fo_outcome_val_1]
      ,[stake_fo_outcome_desc_1]
      ,[stake_fo_outcome_val_2]
      ,[stake_fo_outcome_desc_2]
      ,[stake_fo_outcome_val_3]
      ,[stake_fo_outcome_desc_3]
      ,[stake_fo_outcome_val_4]
      ,[stake_fo_outcome_desc_4]
      ,[stake_fo_outcome_val_5]
      ,[stake_fo_outcome_desc_5]
      ,[stake_ro_outcome_val_1]
      ,[stake_ro_outcome_desc_1]
      ,[stake_ro_outcome_val_2]
      ,[stake_ro_outcome_desc_2]
      ,[stake_ro_outcome_val_3]
      ,[stake_ro_outcome_desc_3]
      ,[stake_ro_outcome_val_4]
      ,[stake_ro_outcome_desc_4]
      ,[stake_ro_outcome_val_5]
      ,[stake_ro_outcome_desc_5]
      ,[oper_fo_outcome_val_1]
      ,[oper_fo_outcome_desc_1]
      ,[oper_fo_outcome_val_2]
      ,[oper_fo_outcome_desc_2]
      ,[oper_fo_outcome_val_3]
      ,[oper_fo_outcome_desc_3]
      ,[oper_fo_outcome_val_4]
      ,[oper_fo_outcome_desc_4]
      ,[oper_fo_outcome_val_5]
      ,[oper_fo_outcome_desc_5]
      ,[oper_ro_outcome_val_1]
      ,[oper_ro_outcome_desc_1]
      ,[oper_ro_outcome_val_2]
      ,[oper_ro_outcome_desc_2]
      ,[oper_ro_outcome_val_3]
      ,[oper_ro_outcome_desc_3]
      ,[oper_ro_outcome_val_4]
      ,[oper_ro_outcome_desc_4]
      ,[oper_ro_outcome_val_5]
      ,[oper_ro_outcome_desc_5]
      ,[risk_fo_outcome_val_1]
      ,[risk_fo_outcome_desc_1]
      ,[risk_fo_outcome_val_2]
      ,[risk_fo_outcome_desc_2]
      ,[risk_fo_outcome_val_3]
      ,[risk_fo_outcome_desc_3]
      ,[risk_fo_outcome_val_4]
      ,[risk_fo_outcome_desc_4]
      ,[risk_fo_outcome_val_5]
      ,[risk_fo_outcome_desc_5]
      ,[risk_ro_outcome_val_1]
      ,[risk_ro_outcome_desc_1]
      ,[risk_ro_outcome_val_2]
      ,[risk_ro_outcome_desc_2]
      ,[risk_ro_outcome_val_3]
      ,[risk_ro_outcome_desc_3]
      ,[risk_ro_outcome_val_4]
      ,[risk_ro_outcome_desc_4]
      ,[risk_ro_outcome_val_5]
      ,[risk_ro_outcome_desc_5]
  FROM [GovCapSurvey_DB].[dbo].[outcome] o
  where company_id = {0}
  and not exists (select 1 from assessment a where a.inserted_by={1} and a.company_id = o.company_id and a.assessment_date=o.assessment_date)
  order by assessment_date desc", user.Company_id, user.Id)
                    /*.OrderByDescending(n => n.Assessment_date)*/
                    .ToListAsync();

                ViewBag.outcome = ViewBag.outcomes[0];
            }
            else
            {
                ViewBag.outcomes = await _context.Outcome
                    .Where(m => m.Company_id == user.Company_id && m.Assessment_date == DateTime.Parse(value))
                    .ToListAsync();

                ViewBag.outcome = ViewBag.outcomes[0];
            }

            return View();
        }

        // POST: Assessments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company_id,Assessment_date,Vision_agreement,Core_values_agreement,Mission_statement_agreement,Vision_outcome_agreement,Competitive_strategy_agreement,Company_composite_score,Strat_people_score,Strat_resources_score,Strat_processes_score,Strat_culture_score,Strat_composite_score,Stake_people_score,Stake_resources_score,Stake_processes_score,Stake_culture_score,Stake_composite_score,Oper_people_score,Oper_resources_score,Oper_processes_score,Oper_culture_score,Oper_composite_score,Risk_people_score,Risk_resources_score,Risk_processes_score,Risk_culture_score,Risk_composite_score")] Assessment assessment)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (ModelState.IsValid)
            {
                /*_context.Add(assessment);
                await _context.SaveChangesAsync();*/
                await _context.Database.ExecuteSqlCommandAsync(@"
INSERT INTO [dbo].[assessment]
           ([company_id]
           ,[assessment_date]
           ,[Vision_agreement]
           ,[Core_values_agreement]
           ,[Mission_statement_agreement]
           ,[Vision_outcome_agreement]
           ,[Competitive_strategy_agreement]
           ,[Company_composite_score]
           ,[Strat_people_score]
           ,[Strat_resources_score]
           ,[Strat_processes_score]
           ,[Strat_culture_score]
           ,[Strat_composite_score]
           ,[Stake_people_score]
           ,[Stake_resources_score]
           ,[Stake_processes_score]
           ,[Stake_culture_score]
           ,[Stake_composite_score]
           ,[Oper_people_score]
           ,[Oper_resources_score]
           ,[Oper_processes_score]
           ,[Oper_culture_score]
           ,[Oper_composite_score]
           ,[Risk_people_score]
           ,[Risk_resources_score]
           ,[Risk_processes_score]
           ,[Risk_culture_score]
           ,[Risk_composite_score]
           ,[inserted_on]
           ,[inserted_by])
     VALUES (@company_id
           ,@assessment_date
           ,@Vision_agreement
           ,@Core_values_agreement
            ,@Mission_statement_agreement
            ,@Vision_outcome_agreement
            ,@Competitive_strategy_agreement
            ,@Company_composite_score
            ,@Strat_people_score
           ,@Strat_resources_score
           ,@Strat_processes_score
           ,@Strat_culture_score
           ,@Strat_composite_score
           ,@Stake_people_score
           ,@Stake_resources_score
           ,@Stake_processes_score
           ,@Stake_culture_score
           ,@Stake_composite_score
           ,@Oper_people_score
           ,@Oper_resources_score
           ,@Oper_processes_score
           ,@Oper_culture_score
           ,@Oper_composite_score
           ,@Risk_people_score
           ,@Risk_resources_score
           ,@Risk_processes_score
           ,@Risk_culture_score
           ,@Risk_composite_score
           ,GETDATE()
           ,@inserted_by)",
             new SqlParameter("@company_id", (object)assessment.Company_id ?? DBNull.Value),
             new SqlParameter("@assessment_date", (object)assessment.Assessment_date ?? DBNull.Value),
             new SqlParameter("@Vision_agreement", (object)assessment.Vision_agreement ?? DBNull.Value),
             new SqlParameter("@Core_values_agreement", (object)assessment.Core_values_agreement ?? DBNull.Value),
             new SqlParameter("@Mission_statement_agreement", (object)assessment.Mission_statement_agreement ?? DBNull.Value),
             new SqlParameter("@Vision_outcome_agreement", (object)assessment.Vision_outcome_agreement ?? DBNull.Value),
             new SqlParameter("@Competitive_strategy_agreement", (object)assessment.Competitive_strategy_agreement ?? DBNull.Value),
             new SqlParameter("@Company_composite_score", (object)assessment.Company_composite_score ?? DBNull.Value),
             new SqlParameter("@Strat_people_score", (object)assessment.Strat_people_score ?? DBNull.Value),
             new SqlParameter("@Strat_resources_score", (object)assessment.Strat_resources_score ?? DBNull.Value),
             new SqlParameter("@Strat_processes_score", (object)assessment.Strat_processes_score ?? DBNull.Value),
             new SqlParameter("@Strat_culture_score", (object)assessment.Strat_culture_score ?? DBNull.Value),
             new SqlParameter("@Strat_composite_score", (object)assessment.Strat_composite_score ?? DBNull.Value),
             new SqlParameter("@Stake_people_score", (object)assessment.Stake_people_score ?? DBNull.Value),
             new SqlParameter("@Stake_resources_score", (object)assessment.Stake_resources_score ?? DBNull.Value),
             new SqlParameter("@Stake_processes_score", (object)assessment.Stake_processes_score ?? DBNull.Value),
             new SqlParameter("@Stake_culture_score", (object)assessment.Stake_culture_score ?? DBNull.Value),
             new SqlParameter("@Stake_composite_score", (object)assessment.Stake_composite_score ?? DBNull.Value),
             new SqlParameter("@Oper_people_score", (object)assessment.Oper_people_score ?? DBNull.Value),
             new SqlParameter("@Oper_resources_score", (object)assessment.Oper_resources_score ?? DBNull.Value),
             new SqlParameter("@Oper_processes_score", (object)assessment.Oper_processes_score ?? DBNull.Value),
             new SqlParameter("@Oper_culture_score", (object)assessment.Oper_culture_score ?? DBNull.Value),
             new SqlParameter("@Oper_composite_score", (object)assessment.Oper_composite_score ?? DBNull.Value),
             new SqlParameter("@Risk_people_score", (object)assessment.Risk_people_score ?? DBNull.Value),
             new SqlParameter("@Risk_resources_score", (object)assessment.Risk_resources_score ?? DBNull.Value),
             new SqlParameter("@Risk_processes_score", (object)assessment.Risk_processes_score ?? DBNull.Value),
             new SqlParameter("@Risk_culture_score", (object)assessment.Risk_culture_score ?? DBNull.Value),
             new SqlParameter("@Risk_composite_score", (object)assessment.Risk_composite_score ?? DBNull.Value),
             new SqlParameter("@inserted_by", User.Identity.Name)
             );
                return RedirectToAction(nameof(Index));
            }
            return View(assessment);
        }

        // GET: Assessments/Edit/5
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

            var assessment = await _context.Assessment.FindAsync(id);

            if (assessment == null)
            {
                return NotFound();
            }
            
            ViewBag.dropdownlist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Agreement").ToListAsync();

            ViewBag.peopleratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-People").ToListAsync();

            ViewBag.resourcesratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Resources").ToListAsync();

            ViewBag.processesratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Processes").ToListAsync();

            ViewBag.cultureratinglist = await _context.Dropdown_Code
                .Where(x => x.Table_name == "Assessment-Culture").ToListAsync();

            ViewBag.company = await _context.Companies
                .Where(c => c.Id == assessment.Company_id).ToListAsync();

            ViewBag.outcome = await _context.Outcome
                .FirstOrDefaultAsync(m => m.Company_id == assessment.Company_id && m.Assessment_date == assessment.Assessment_date);

            return View(assessment);
        }

        // POST: Assessments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company_id,Assessment_date,Vision_agreement,Core_values_agreement,Mission_statement_agreement,Vision_outcome_agreement,Competitive_strategy_agreement,Company_composite_score,Strat_people_score,Strat_resources_score,Strat_processes_score,Strat_culture_score,Strat_composite_score,Stake_people_score,Stake_resources_score,Stake_processes_score,Stake_culture_score,Stake_composite_score,Oper_people_score,Oper_resources_score,Oper_processes_score,Oper_culture_score,Oper_composite_score,Risk_people_score,Risk_resources_score,Risk_processes_score,Risk_culture_score,Risk_composite_score")] Assessment assessment)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            if (id != assessment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assessment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssessmentExists(assessment.Id))
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
            return View(assessment);
        }

        // GET: Assessments/Delete/5
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

            var assessment = await _context.Assessment
                .FirstOrDefaultAsync(m => m.Id == id);

            ViewBag.company = await _context.Companies
                .FirstOrDefaultAsync(c => c.Id == assessment.Company_id);

            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        // POST: Assessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }
            ViewBag.Admin = User.Claims.ToList()[2].Value;
            var assessment = await _context.Assessment.FindAsync(id);
            _context.Assessment.Remove(assessment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssessmentExists(int id)
        {
            return _context.Assessment.Any(e => e.Id == id);
        }
    }
}
