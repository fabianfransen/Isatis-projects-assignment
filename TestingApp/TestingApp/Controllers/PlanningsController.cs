using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestingApp.Data;
using TestingApp.Models;
using TestingApp.Repository;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TestingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanningsController : ControllerBase
    {
        private readonly IPlanningRepository _planningRepository;
        public PlanningsController(IPlanningRepository p)
        {
            _planningRepository =  p;
        }

        // GET: Plannings



        //public JsonResult Get()
        //{
        //    string query = @"select Id, Name from dbo.Planning";
        //    DataTable table = new DataTable();
        //    string sqlDataSource = _planningRepository.GetConnectionString("TestingAppContext");
        //}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Planning> plannings = await _planningRepository.GetAll();
            return Ok( plannings.ToArray());
            //return plannings.Any() ?
            //              (plannings.ToArray()) :
            //              Problem("Entity set 'TestingAppContext.Planning'  is null.");
        }
        //public IEnumerable<Planning> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new Planning
        //    {
        //        Week = 10,
        //        Hours = 500
        //    })
        //    .ToArray();
        //}

        // GET: Plannings/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Planning == null)
        //    {
        //        return NotFound();
        //    }

        //    var planning = await _context.Planning
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (planning == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(planning);
        //}

        // GET: Plannings/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Plannings/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Week,Hours")] Planning planning)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(planning);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(planning);
        //}

        //// GET: Plannings/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Planning == null)
        //    {
        //        return NotFound();
        //    }

        //    var planning = await _context.Planning.FindAsync(id);
        //    if (planning == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(planning);
        //}

        //// POST: Plannings/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Week,Hours")] Planning planning)
        //{
        //    if (id != planning.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(planning);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PlanningExists(planning.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(planning);
        //}

        //// GET: Plannings/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Planning == null)
        //    {
        //        return NotFound();
        //    }

        //    var planning = await _context.Planning
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (planning == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(planning);
        //}

        //// POST: Plannings/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Planning == null)
        //    {
        //        return Problem("Entity set 'TestingAppContext.Planning'  is null.");
        //    }
        //    var planning = await _context.Planning.FindAsync(id);
        //    if (planning != null)
        //    {
        //        _context.Planning.Remove(planning);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PlanningExists(int id)
        //{
        //  return (_context.Planning?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
