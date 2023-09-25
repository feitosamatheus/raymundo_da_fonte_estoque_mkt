using Estoque.Application.Interfaces;
using Estoque.Application.ViewModels.Login;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iniciandoProjeto.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILoginService _loginService;

        public AccountController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            try
            {
                var resultadoLogin = await _loginService.EfetivarLogin(model);

                if (resultadoLogin)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Erro ao realizar o login");
                return View(model);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "Erro ao realizar o login. Contate o administrador");
                return View(model);
            }
        }   

        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel login)
        {
            if(!ModelState.IsValid)
                return View(login);

            var user = new IdentityUser(){ UserName = login.User};
            var result = await _userManager.CreateAsync(user, login.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Member");
                return RedirectToAction("Login", "account");
            }

            ModelState.AddModelError("Registro", "Falha ao registrar o usuário");
            return View(login);
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
