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

        public IActionResult Login(string Page)
        {
            if(_signInManager.IsSignedIn(User))
            {
              return RedirectToAction("Index","Home");
            }
            return View(new LoginViewModel
            {
                Page = Page
            });

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName,Password,Page")] LoginViewModel LoginVM)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("UserName,Password,ConfirmPassword")] RegisterViewModel RegisterVM)
        {
            if (ModelState.IsValid) 
            {
                var user = new User { UserName = RegisterVM.UserName };
                var result = await _userManager.CreateAsync(user, RegisterVM.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    this.ModelState.AddModelError("", "Falha ao registrar o usuario");
                }
            }
            return View(RegisterVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
