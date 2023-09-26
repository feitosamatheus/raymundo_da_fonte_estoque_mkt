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

            var resultadoLogin = await _loginService.EfetivarLogin(model);

            if (resultadoLogin)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Erro ao realizar o login");
            return View(model);
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
            
            var resultadoRegistro = await _loginService.EfetivarRegistro(login);

            if (resultadoRegistro)
            {
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
            var resultadoLogout = await _loginService.EfetivarLogout();
            if (resultadoLogout)
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "Erro ao realizar o logout. Contate o administrador");
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
