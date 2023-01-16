using FighteR_PG.Context;
using FighteR_PG.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FighteR_PG.Controllers
{
    public class BossController : Controller
    {
        private readonly IBossRepository _bossRepository;

        public BossController(IBossRepository bossRepository)
        {
            _bossRepository = bossRepository;
        }

        public IActionResult Details(int? id)
        {
            if (id == null || _bossRepository.Bosses == null)
            {
                return NotFound();
            }

            var boss =  _bossRepository.Bosses.FirstOrDefault(m => m.BossId == id);
            if (boss == null)
            {
                return NotFound();
            }

            return View(boss);
        }
    }
}
