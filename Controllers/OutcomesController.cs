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
    public class OutcomesController : Controller
    {
        private readonly GCSContext _context;

        public OutcomesController(GCSContext context)
        {
            _context = context;
        }

        // GET: Outcomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Outcome.ToListAsync());
        }

        // GET: Outcomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outcome = await _context.Outcome
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outcome == null)
            {
                return NotFound();
            }

            return View(outcome);
        }

        // GET: Outcomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Outcomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company_id,Assessment_date,strat_fo_outcome_val_1,strat_fo_outcome_desc_1,strat_fo_outcome_val_2,strat_fo_outcome_desc_2,strat_fo_outcome_val_3,strat_fo_outcome_desc_3,strat_fo_outcome_val_4,strat_fo_outcome_desc_4,strat_fo_outcome_val_5,strat_fo_outcome_desc_5,strat_ro_outcome_val_1,strat_ro_outcome_desc_1,strat_ro_outcome_val_2,strat_ro_outcome_desc_2,strat_ro_outcome_val_3,strat_ro_outcome_desc_3,strat_ro_outcome_val_4,strat_ro_outcome_desc_4,strat_ro_outcome_val_5,strat_ro_outcome_desc_5,stake_fo_outcome_val_1,stake_fo_outcome_desc_1,stake_fo_outcome_val_2,stake_fo_outcome_desc_2,stake_fo_outcome_val_3,stake_fo_outcome_desc_3,stake_fo_outcome_val_4,stake_fo_outcome_desc_4,stake_fo_outcome_val_5,stake_fo_outcome_desc_5,stake_ro_outcome_val_1,stake_ro_outcome_desc_1,stake_ro_outcome_val_2,stake_ro_outcome_desc_2,stake_ro_outcome_val_3,stake_ro_outcome_desc_3,stake_ro_outcome_val_4,stake_ro_outcome_desc_4,stake_ro_outcome_val_5,stake_ro_outcome_desc_5,oper_fo_outcome_val_1,oper_fo_outcome_desc_1,oper_fo_outcome_val_2,oper_fo_outcome_desc_2,oper_fo_outcome_val_3,oper_fo_outcome_desc_3,oper_fo_outcome_val_4,oper_fo_outcome_desc_4,oper_fo_outcome_val_5,oper_fo_outcome_desc_5,oper_ro_outcome_val_1,oper_ro_outcome_desc_1,oper_ro_outcome_val_2,oper_ro_outcome_desc_2,oper_ro_outcome_val_3,oper_ro_outcome_desc_3,oper_ro_outcome_val_4,oper_ro_outcome_desc_4,oper_ro_outcome_val_5,oper_ro_outcome_desc_5,risk_fo_outcome_val_1,risk_fo_outcome_desc_1,risk_fo_outcome_val_2,risk_fo_outcome_desc_2,risk_fo_outcome_val_3,risk_fo_outcome_desc_3,risk_fo_outcome_val_4,risk_fo_outcome_desc_4,risk_fo_outcome_val_5,risk_fo_outcome_desc_5,risk_ro_outcome_val_1,risk_ro_outcome_desc_1,risk_ro_outcome_val_2,risk_ro_outcome_desc_2,risk_ro_outcome_val_3,risk_ro_outcome_desc_3,risk_ro_outcome_val_4,risk_ro_outcome_desc_4,risk_ro_outcome_val_5,risk_ro_outcome_desc_5")] Outcome outcome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outcome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outcome);
        }

        // GET: Outcomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outcome = await _context.Outcome.FindAsync(id);
            if (outcome == null)
            {
                return NotFound();
            }
            return View(outcome);
        }

        // POST: Outcomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company_id,Assessment_date,strat_fo_outcome_val_1,strat_fo_outcome_desc_1,strat_fo_outcome_val_2,strat_fo_outcome_desc_2,strat_fo_outcome_val_3,strat_fo_outcome_desc_3,strat_fo_outcome_val_4,strat_fo_outcome_desc_4,strat_fo_outcome_val_5,strat_fo_outcome_desc_5,strat_ro_outcome_val_1,strat_ro_outcome_desc_1,strat_ro_outcome_val_2,strat_ro_outcome_desc_2,strat_ro_outcome_val_3,strat_ro_outcome_desc_3,strat_ro_outcome_val_4,strat_ro_outcome_desc_4,strat_ro_outcome_val_5,strat_ro_outcome_desc_5,stake_fo_outcome_val_1,stake_fo_outcome_desc_1,stake_fo_outcome_val_2,stake_fo_outcome_desc_2,stake_fo_outcome_val_3,stake_fo_outcome_desc_3,stake_fo_outcome_val_4,stake_fo_outcome_desc_4,stake_fo_outcome_val_5,stake_fo_outcome_desc_5,stake_ro_outcome_val_1,stake_ro_outcome_desc_1,stake_ro_outcome_val_2,stake_ro_outcome_desc_2,stake_ro_outcome_val_3,stake_ro_outcome_desc_3,stake_ro_outcome_val_4,stake_ro_outcome_desc_4,stake_ro_outcome_val_5,stake_ro_outcome_desc_5,oper_fo_outcome_val_1,oper_fo_outcome_desc_1,oper_fo_outcome_val_2,oper_fo_outcome_desc_2,oper_fo_outcome_val_3,oper_fo_outcome_desc_3,oper_fo_outcome_val_4,oper_fo_outcome_desc_4,oper_fo_outcome_val_5,oper_fo_outcome_desc_5,oper_ro_outcome_val_1,oper_ro_outcome_desc_1,oper_ro_outcome_val_2,oper_ro_outcome_desc_2,oper_ro_outcome_val_3,oper_ro_outcome_desc_3,oper_ro_outcome_val_4,oper_ro_outcome_desc_4,oper_ro_outcome_val_5,oper_ro_outcome_desc_5,risk_fo_outcome_val_1,risk_fo_outcome_desc_1,risk_fo_outcome_val_2,risk_fo_outcome_desc_2,risk_fo_outcome_val_3,risk_fo_outcome_desc_3,risk_fo_outcome_val_4,risk_fo_outcome_desc_4,risk_fo_outcome_val_5,risk_fo_outcome_desc_5,risk_ro_outcome_val_1,risk_ro_outcome_desc_1,risk_ro_outcome_val_2,risk_ro_outcome_desc_2,risk_ro_outcome_val_3,risk_ro_outcome_desc_3,risk_ro_outcome_val_4,risk_ro_outcome_desc_4,risk_ro_outcome_val_5,risk_ro_outcome_desc_5")] Outcome outcome)
        {
            if (id != outcome.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outcome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutcomeExists(outcome.Id))
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
            return View(outcome);
        }

        // GET: Outcomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outcome = await _context.Outcome
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outcome == null)
            {
                return NotFound();
            }

            return View(outcome);
        }

        // POST: Outcomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var outcome = await _context.Outcome.FindAsync(id);
            _context.Outcome.Remove(outcome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutcomeExists(int id)
        {
            return _context.Outcome.Any(e => e.Id == id);
        }
    }
}
