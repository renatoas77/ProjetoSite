using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FighteR_PG.Context;
using FighteR_PG.Models;

namespace FighteR_PG.Controllers
{
    public class SexesController : Controller
    {
        private readonly AppDbContext _context;

        public SexesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Sexes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Sexes.ToListAsync());
        }

        // GET: Sexes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sexes == null)
            {
                return NotFound();
            }

            var sex = await _context.Sexes
                .FirstOrDefaultAsync(m => m.SexId == id);
            if (sex == null)
            {
                return NotFound();
            }

            return View(sex);
        }

        // GET: Sexes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sexes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SexId,SexCharacter")] Sex sex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sex);
        }

        // GET: Sexes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sexes == null)
            {
                return NotFound();
            }

            var sex = await _context.Sexes.FindAsync(id);
            if (sex == null)
            {
                return NotFound();
            }
            return View(sex);
        }

        // POST: Sexes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SexId,SexCharacter")] Sex sex)
        {
            if (id != sex.SexId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SexExists(sex.SexId))
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
            return View(sex);
        }

        // GET: Sexes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sexes == null)
            {
                return NotFound();
            }

            var sex = await _context.Sexes
                .FirstOrDefaultAsync(m => m.SexId == id);
            if (sex == null)
            {
                return NotFound();
            }

            return View(sex);
        }

        // POST: Sexes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sexes == null)
            {
                return Problem("Entity set 'AppDbContext.Sexes'  is null.");
            }
            var sex = await _context.Sexes.FindAsync(id);
            if (sex != null)
            {
                _context.Sexes.Remove(sex);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SexExists(int id)
        {
          return _context.Sexes.Any(e => e.SexId == id);
        }
    }
}
