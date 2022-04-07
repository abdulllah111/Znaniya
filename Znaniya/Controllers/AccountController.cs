using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Znaniya.Models;

namespace Znaniya.Controllers
{
        [Authorize]
        public class AccountController : Controller
        {
            private readonly UserManager<IdentityUser> userManager;
            private readonly SignInManager<IdentityUser> signInManager;
            public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
            {
                userManager = userMgr;
                signInManager = signinMgr;
            }

            [AllowAnonymous]
            public IActionResult Login()
            {
                return View(new LoginViewModel());
            }
            [HttpPost]
            [AllowAnonymous]
            public async Task<IActionResult> Login(LoginViewModel model)
            {
                if (ModelState.IsValid)
                {
                    IdentityUser user = await userManager.FindByNameAsync(model.UserName);
                    if (user != null)
                    {
                        await signInManager.SignOutAsync();
                        Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                    }
                    }
                    ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
                }
                return View(model);
            }

            [Authorize]
            public async Task<IActionResult> Logout()
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
        }
    }
