using FighteR_PG.Models;
using FighteR_PG.Context;
using FighteR_PG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using FighteR_PG.Repositories.IRepositories;

namespace FighteR_PG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICharacterRepository _characterRepository;
        private readonly IBossRepository _bossRepository;

        public HomeController(ILogger<HomeController> logger, ICharacterRepository characterRepository, IBossRepository bossRepository)
        {
            _logger = logger;
            _characterRepository = characterRepository;
            _bossRepository = bossRepository;
        }

        public IActionResult Index()
        {
            BossCharacterViewModel var = new BossCharacterViewModel();

            var.bosses = _bossRepository.Bosses.OrderBy(b => b.BossId);
            var.characters = _characterRepository.Characters.OrderBy(c => c.CharacterId);

            return View(var);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}