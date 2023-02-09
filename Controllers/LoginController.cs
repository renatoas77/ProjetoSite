using FighteR_PG.Models;
using FighteR_PG.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FighteR_PG.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName,Password")] LoginViewModel LoginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(LoginVM);
            }

            var user = await _userManager.FindByNameAsync(LoginVM.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, LoginVM.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(LoginVM.Page))
                    {
                        return RedirectToAction ("Index", "Home");
                    }
                    return Redirect(LoginVM.Page);
                }
            }

            ModelState.AddModelError("", "Dados de login invalidos!");
            return View(LoginVM);
        }

        public IActionResult Register()
        {
            return View();
        }



        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
