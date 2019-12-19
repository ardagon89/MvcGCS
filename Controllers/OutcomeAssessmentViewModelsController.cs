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
    public class OutcomeAssessmentViewModelsController : Controller
    {
        private readonly GCSContext _context;

        public OutcomeAssessmentViewModelsController(GCSContext context)
        {
            _context = context;
        }

        // GET: OutcomeAssessmentViewModels
        public async Task<IActionResult> Index()
        {
            OutcomeAssessmentViewModel oa = new OutcomeAssessmentViewModel();
            Assessment a =await _context.Assessment
                .FirstOrDefaultAsync(m => m.Id == 1);
            Outcome o =await _context.Outcome
                .FirstOrDefaultAsync(m => m.Id == 1);
            oa.assessment = a;
            oa.outcome = o;
            oa.guid = Guid.NewGuid();

            List<OutcomeAssessmentViewModel> loa = new List<OutcomeAssessmentViewModel>();
            loa.Add(oa);

            //return View(await _context.OutcomeAssessmentViewModel.ToListAsync());
            return View(loa);
        }

        // GET: OutcomeAssessmentViewModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outcomeAssessmentViewModel = await _context.OutcomeAssessmentViewModel
                .FirstOrDefaultAsync(m => m.guid == id);
            if (outcomeAssessmentViewModel == null)
            {
                return NotFound();
            }

            return View(outcomeAssessmentViewModel);
        }

        // GET: OutcomeAssessmentViewModels/Create
        public IActionResult Create()
        {
            OutcomeAssessmentViewModel oa = new OutcomeAssessmentViewModel();
            Assessment a =  _context.Assessment
                .FirstOrDefault(m => m.Id == 1);
            Outcome o = _context.Outcome
                .FirstOrDefault(m => m.Id == 1);
            oa.assessment = a;
            oa.outcome = o;
            oa.guid = Guid.NewGuid();

            return View(oa);
        }

        // POST: OutcomeAssessmentViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("guid")] OutcomeAssessmentViewModel outcomeAssessmentViewModel)
        {
            if (ModelState.IsValid)
            {
                outcomeAssessmentViewModel.guid = Guid.NewGuid();
                //_context.Add(outcomeAssessmentViewModel);
                //await _context.SaveChangesAsync();
                Assessment a =await _context.Assessment
                    .FirstOrDefaultAsync(m => m.Id == 1);
                Outcome o =await _context.Outcome
                    .FirstOrDefaultAsync(m => m.Id == 1);
                outcomeAssessmentViewModel.assessment = a;
                outcomeAssessmentViewModel.outcome = o;
                return RedirectToAction(nameof(Index));
            }
            return View(outcomeAssessmentViewModel);
        }

        // GET: OutcomeAssessmentViewModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outcomeAssessmentViewModel = await _context.OutcomeAssessmentViewModel.FindAsync(id);
            if (outcomeAssessmentViewModel == null)
            {
                return NotFound();
            }
            return View(outcomeAssessmentViewModel);
        }

        // POST: OutcomeAssessmentViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("guid")] OutcomeAssessmentViewModel outcomeAssessmentViewModel)
        {
            if (id != outcomeAssessmentViewModel.guid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outcomeAssessmentViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutcomeAssessmentViewModelExists(outcomeAssessmentViewModel.guid))
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
            return View(outcomeAssessmentViewModel);
        }

        // GET: OutcomeAssessmentViewModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outcomeAssessmentViewModel = await _context.OutcomeAssessmentViewModel
                .FirstOrDefaultAsync(m => m.guid == id);
            if (outcomeAssessmentViewModel == null)
            {
                return NotFound();
            }

            return View(outcomeAssessmentViewModel);
        }

        // POST: OutcomeAssessmentViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var outcomeAssessmentViewModel = await _context.OutcomeAssessmentViewModel.FindAsync(id);
            _context.OutcomeAssessmentViewModel.Remove(outcomeAssessmentViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutcomeAssessmentViewModelExists(Guid id)
        {
            return _context.OutcomeAssessmentViewModel.Any(e => e.guid == id);
        }
    }
}
