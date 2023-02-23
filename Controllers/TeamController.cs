using FighteR_PG.Context;
using FighteR_PG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FighteR_PG.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly Selection _selection;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public TeamController(Selection selection, UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext context)
        {
            _selection = selection;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var teams = await _context.Team.Where(t => t.UserId == _userManager.GetUserId(User))
                                           .Include(m => m.Members)
                                           .ThenInclude(c => c.Character)
                                           .ToListAsync();

            return View(teams);
        }

        public IActionResult Salvar()
        {
            if(_signInManager.IsSignedIn(User) && _selection.GetSelectedMembers().Count() == 3)
            {
  
               

                return View();
            }

           return RedirectToAction("Login","Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Salvar(Team team)
        {
            if(ModelState.IsValid)
            {
                team.Members = new List<TeamMember>();

                var SelectedMembers = _selection.GetSelectedMembers();
                _selection.ClearSelection();

                foreach(var SelectedMember in SelectedMembers)
                {
                    team.Members.Add(new TeamMember() { Character = SelectedMember.Character });
                }

                team.User = await _userManager.FindByNameAsync(User.Identity.Name);
                if(team.User != null)
                {
                    _context.Add(team);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index","Home");
                }
                return View(team);
            }
            return View(team);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null || _context.Team == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .Include(m => m.Members)
                .ThenInclude(c => c.Character)
                .FirstOrDefaultAsync(m => m.TeamId == id);
            if(team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if(_context.Team == null)
            {
                return Problem("Entity set 'AppDbContext.Characters'  is null.");
            }
            var team = await _context.Team.FindAsync(id);
            if(team != null)
            {
                _context.Team.Remove(team);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
