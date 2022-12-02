using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Controllers
{
    public class PVPLocalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
