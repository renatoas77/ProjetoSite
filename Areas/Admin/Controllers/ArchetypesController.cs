using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FighteR_PG.Context;
using FighteR_PG.Models;
using Microsoft.AspNetCore.Authorization;

namespace FighteR_PG.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("Admin")]
    public class ArchetypesController : Controller
    {
        private readonly AppDbContext _context;

        public ArchetypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Archetypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Archetypes.ToListAsync());
        }

        // GET: Admin/Archetypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Archetypes == null)
            {
                return NotFound();
            }

            var archetype = await _context.Archetypes
                .FirstOrDefaultAsync(m => m.ArchetypeId == id);
            if (archetype == null)
            {
                return NotFound();
            }

            return View(archetype);
        }

        // GET: Admin/Archetypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Archetypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArchetypeId,Name,Description")] Archetype archetype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(archetype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(archetype);
        }

        // GET: Admin/Archetypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Archetypes == null)
            {
                return NotFound();
            }

            var archetype = await _context.Archetypes.FindAsync(id);
            if (archetype == null)
            {
                return NotFound();
            }
            return View(archetype);
        }

        // POST: Admin/Archetypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArchetypeId,Name,Description")] Archetype archetype)
        {
            if (id != archetype.ArchetypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(archetype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchetypeExists(archetype.ArchetypeId))
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
            return View(archetype);
        }

        // GET: Admin/Archetypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Archetypes == null)
            {
                return NotFound();
            }

            var archetype = await _context.Archetypes
                .FirstOrDefaultAsync(m => m.ArchetypeId == id);
            if (archetype == null)
            {
                return NotFound();
            }

            return View(archetype);
        }

        // POST: Admin/Archetypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Archetypes == null)
            {
                return Problem("Entity set 'AppDbContext.Archetypes'  is null.");
            }
            var archetype = await _context.Archetypes.FindAsync(id);
            if (archetype != null)
            {
                _context.Archetypes.Remove(archetype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchetypeExists(int id)
        {
          return _context.Archetypes.Any(e => e.ArchetypeId == id);
        }
    }
}
