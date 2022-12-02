using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Controllers
{
    public class HudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
