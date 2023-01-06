using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FighteR_PG.Context;
using FighteR_PG.Models;

namespace FighteR_PG.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TiersController : Controller
    {
        private readonly AppDbContext _context;

        public TiersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Tiers
        public async Task<IActionResult> Index()
        {
              return View(await _context.Tier.ToListAsync());
        }

        // GET: Admin/Tiers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tier == null)
            {
                return NotFound();
            }

            var tier = await _context.Tier
                .FirstOrDefaultAsync(m => m.TierId == id);
            if (tier == null)
            {
                return NotFound();
            }

            return View(tier);
        }

        // GET: Admin/Tiers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tiers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TierId,Name")] Tier tier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tier);
        }

        // GET: Admin/Tiers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tier == null)
            {
                return NotFound();
            }

            var tier = await _context.Tier.FindAsync(id);
            if (tier == null)
            {
                return NotFound();
            }
            return View(tier);
        }

        // POST: Admin/Tiers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TierId,Name")] Tier tier)
        {
            if (id != tier.TierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TierExists(tier.TierId))
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
            return View(tier);
        }

        // GET: Admin/Tiers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tier == null)
            {
                return NotFound();
            }

            var tier = await _context.Tier
                .FirstOrDefaultAsync(m => m.TierId == id);
            if (tier == null)
            {
                return NotFound();
            }

            return View(tier);
        }

        // POST: Admin/Tiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tier == null)
            {
                return Problem("Entity set 'AppDbContext.Tier'  is null.");
            }
            var tier = await _context.Tier.FindAsync(id);
            if (tier != null)
            {
                _context.Tier.Remove(tier);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TierExists(int id)
        {
          return _context.Tier.Any(e => e.TierId == id);
        }
    }
}
