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
    public class CharactersController : Controller
    {
        private readonly AppDbContext _context;

        public CharactersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Characters
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Characters.Include(c => c.Archetype).Include(c => c.Sex);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Characters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(c => c.Archetype)
                .Include(c => c.Sex)
                .FirstOrDefaultAsync(m => m.CharacterId == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // GET: Admin/Characters/Create
        public IActionResult Create()
        {
            ViewData["ArchetypeId"] = new SelectList(_context.Archetypes, "ArchetypeId", "Name");
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter");
            return View();
        }

        // POST: Admin/Characters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CharacterId,Name,Image,Icon,Specie,Class,Height,Weight,Age,Likes,Dislikes,Hobbie,Food,Curiosity,Ideias,Background,Conclusao,SkilName01,SkilName02,SkilName03,SkilName04,SkilName05,SkilName06,SkilName07,SkilName08,SkilName09,SkilName10,SkilName11,SkilName12,SkilDesc01,SkilDesc02,SkilDesc03,SkilDesc04,SkilDesc05,SkilDesc06,SkilDesc07,SkilDesc08,SkilDesc09,SkilDesc10,SkilDesc11,SkilDesc12,SkilImage01,SkilImage02,SkilImage03,SkilImage04,SkilImage05,SkilImage06,SkilImage07,SkilImage08,SkilImage09,SkilImage10,SkilImage11,SkilImage12,Special01,Special02,SpecialDesc01,SpecialDesc02,SpecialImage01,SpecialImage02,Fury,Hit01,Hit02,StandComboImage01,StandComboImage02,WalkingComboImage01,WalkingComboImage02,RunningComboImage01,RunningComboImage02,JumpComboImage01,JumpComboImage02,RunningJumpComboImage01,RunningJumpComboImage02,StandCombo01,StandCombo02,WalkingCombo01,WalkingCombo02,RunningCombo01,RunningCombo02,JumpCombo01,JumpCombo02,RunningJumpCombo01,RunningJumpCombo02,ArchetypeId,SexId")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArchetypeId"] = new SelectList(_context.Archetypes, "ArchetypeId", "Name", character.ArchetypeId);
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter", character.SexId);
            return View(character);
        }

        // GET: Admin/Characters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            ViewData["ArchetypeId"] = new SelectList(_context.Archetypes, "ArchetypeId", "Name", character.ArchetypeId);
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter", character.SexId);
            return View(character);
        }

        // POST: Admin/Characters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CharacterId,Name,Image,Icon,Specie,Class,Height,Weight,Age,Likes,Dislikes,Hobbie,Food,Curiosity,Ideias,Background,Conclusao,SkilName01,SkilName02,SkilName03,SkilName04,SkilName05,SkilName06,SkilName07,SkilName08,SkilName09,SkilName10,SkilName11,SkilName12,SkilDesc01,SkilDesc02,SkilDesc03,SkilDesc04,SkilDesc05,SkilDesc06,SkilDesc07,SkilDesc08,SkilDesc09,SkilDesc10,SkilDesc11,SkilDesc12,SkilImage01,SkilImage02,SkilImage03,SkilImage04,SkilImage05,SkilImage06,SkilImage07,SkilImage08,SkilImage09,SkilImage10,SkilImage11,SkilImage12,Special01,Special02,SpecialDesc01,SpecialDesc02,SpecialImage01,SpecialImage02,Fury,Hit01,Hit02,StandComboImage01,StandComboImage02,WalkingComboImage01,WalkingComboImage02,RunningComboImage01,RunningComboImage02,JumpComboImage01,JumpComboImage02,RunningJumpComboImage01,RunningJumpComboImage02,StandCombo01,StandCombo02,WalkingCombo01,WalkingCombo02,RunningCombo01,RunningCombo02,JumpCombo01,JumpCombo02,RunningJumpCombo01,RunningJumpCombo02,ArchetypeId,SexId")] Character character)
        {
            if (id != character.CharacterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.CharacterId))
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
            ViewData["ArchetypeId"] = new SelectList(_context.Archetypes, "ArchetypeId", "Name", character.ArchetypeId);
            ViewData["SexId"] = new SelectList(_context.Sexes, "SexId", "SexCharacter", character.SexId);
            return View(character);
        }

        // GET: Admin/Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(c => c.Archetype)
                .Include(c => c.Sex)
                .FirstOrDefaultAsync(m => m.CharacterId == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Admin/Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Characters == null)
            {
                return Problem("Entity set 'AppDbContext.Characters'  is null.");
            }
            var character = await _context.Characters.FindAsync(id);
            if (character != null)
            {
                _context.Characters.Remove(character);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterExists(int id)
        {
          return _context.Characters.Any(e => e.CharacterId == id);
        }
    }
}
