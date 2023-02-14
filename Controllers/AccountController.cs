using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
