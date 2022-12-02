using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Controllers
{
    public class FreeForAllController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
