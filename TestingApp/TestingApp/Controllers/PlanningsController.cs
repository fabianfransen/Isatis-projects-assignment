using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestingApp.Data;
using TestingApp.Models;

namespace TestingApp.Controllers
{
    public class PlanningsController : Controller
    {
        private readonly TestingAppContext _context;

        public PlanningsController(TestingAppContext context)
        {
            _context = context;
        }

        // GET: Plannings
        public async Task<IActionResult> Index()
        {
              return _context.Planning != null ? 
                          View(await _context.Planning.ToListAsync()) :
                          Problem("Entity set 'TestingAppContext.Planning'  is null.");
        }

        // GET: Plannings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Planning == null)
            {
                return NotFound();
            }

            var planning = await _context.Planning
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planning == null)
            {
                return NotFound();
            }

            return View(planning);
        }

        // GET: Plannings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plannings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Week,Hours")] Planning planning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planning);
        }

        // GET: Plannings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Planning == null)
            {
                return NotFound();
            }

            var planning = await _context.Planning.FindAsync(id);
            if (planning == null)
            {
                return NotFound();
            }
            return View(planning);
        }

        // POST: Plannings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Week,Hours")] Planning planning)
        {
            if (id != planning.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanningExists(planning.Id))
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
            return View(planning);
        }

        // GET: Plannings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Planning == null)
            {
                return NotFound();
            }

            var planning = await _context.Planning
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planning == null)
            {
                return NotFound();
            }

            return View(planning);
        }

        // POST: Plannings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Planning == null)
            {
                return Problem("Entity set 'TestingAppContext.Planning'  is null.");
            }
            var planning = await _context.Planning.FindAsync(id);
            if (planning != null)
            {
                _context.Planning.Remove(planning);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanningExists(int id)
        {
          return (_context.Planning?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
