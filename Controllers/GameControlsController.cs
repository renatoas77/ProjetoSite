using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Controllers
{
    public class GameControlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
