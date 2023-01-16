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
    public class BossesController : Controller
    {
        private readonly AppDbContext _context;

        public BossesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Bosses
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Bosses.Include(b => b.Sex).Include(b => b.Tier);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Bosses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bosses == null)
            {
                return NotFound();
            }

            var boss = await _context.Bosses
                .Include(b => b.Sex)
                .Include(b => b.Tier)
                .FirstOrDefaultAsync(m => m.BossId == id);
            if (boss == null)
            {
                return NotFound();
            }

            return View(boss);
        }

        // GET: Admin/Bosses/Create
        public IActionResult Create()
        {
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter");
            ViewData["TierId"] = new SelectList(_context.Tier, "TierId", "Name");
            return View();
        }

        // POST: Admin/Bosses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BossId,Name,Image,Region,RegionImage,GerneralText,SexId,TierId")] Boss boss)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boss);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter", boss.SexId);
            ViewData["TierId"] = new SelectList(_context.Tier, "TierId", "Name",boss.TierId);
            return View(boss);
        }

        // GET: Admin/Bosses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bosses == null)
            {
                return NotFound();
            }

            var boss = await _context.Bosses.FindAsync(id);
            if (boss == null)
            {
                return NotFound();
            }
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter", boss.SexId);
            ViewData["TierId"] = new SelectList(_context.Tier, "TierId", "Name", boss.TierId);
            return View(boss);
        }

        // POST: Admin/Bosses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BossId,Name,Image,Region,RegionImage,GerneralText,SexId,TierId")] Boss boss)
        {
            if (id != boss.BossId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boss);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BossExists(boss.BossId))
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
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter", boss.SexId);
            ViewData["TierId"] = new SelectList(_context.Tier, "TierId", "Name", boss.TierId);
            return View(boss);
        }

        // GET: Admin/Bosses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bosses == null)
            {
                return NotFound();
            }

            var boss = await _context.Bosses
                .Include(b => b.Sex)
                .Include(b => b.Tier)
                .FirstOrDefaultAsync(m => m.BossId == id);
            if (boss == null)
            {
                return NotFound();
            }

            return View(boss);
        }

        // POST: Admin/Bosses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bosses == null)
            {
                return Problem("Entity set 'AppDbContext.Bosses'  is null.");
            }
            var boss = await _context.Bosses.FindAsync(id);
            if (boss != null)
            {
                _context.Bosses.Remove(boss);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BossExists(int id)
        {
          return _context.Bosses.Any(e => e.BossId == id);
        }
    }
}
