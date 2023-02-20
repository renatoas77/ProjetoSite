using FighteR_PG.Context;
using FighteR_PG.Models;
using FighteR_PG.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

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
    }
}
