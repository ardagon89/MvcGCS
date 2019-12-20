using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GCS.Models;

namespace GCS
{
    public class AssessmentsController : Controller
    {
        private readonly GCSContext _context;

        public AssessmentsController(GCSContext context)
        {
            _context = context;
        }

        // GET: Assessments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Assessment.ToListAsync());
        }

        // GET: Assessments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        // GET: Assessments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Assessments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company_id,Assessment_date,Vision_agreement,Core_values_agreement,Mission_statement_agreement,Vision_outcome_agreement,Competitive_strategy_agreement,Company_composite_score,Strat_people_score,Strat_resources_score,Strat_processes_score,Strat_culture_score,Strat_composite_score,Stake_people_score,Stake_resources_score,Stake_processes_score,Stake_culture_score,Stake_composite_score,Oper_people_score,Oper_resources_score,Oper_processes_score,Oper_culture_score,Oper_composite_score,Risk_people_score,Risk_resources_score,Risk_processes_score,Risk_culture_score,Risk_composite_score")] Assessment assessment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assessment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assessment);
        }

        // GET: Assessments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
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
                .FirstOrDefaultAsync(c => c.Id == assessment.Company_id);

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
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessment
                .FirstOrDefaultAsync(m => m.Id == id);
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
