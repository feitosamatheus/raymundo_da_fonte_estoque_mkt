using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.Repository
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UsuarioRepository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> EfetivarLogin(Usuario login) 
        {
            var ExternalLogins = ( await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            try
            {
                var usuario = await _userManager.FindByEmailAsync(login.Email);
                if (usuario != null)
                {
                    var resultado = _signInManager.PasswordSignInAsync(usuario, login.PasswordHash, false, false);
                    if (resultado.Result.Succeeded)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> EfetivarRegistro(Usuario login)
        {
            try
            {
                var usuario = new IdentityUser() { UserName = login.UserName, Email = login.Email };
                var resultado = await _userManager.CreateAsync(usuario, login.PasswordHash);

                if (resultado.Succeeded)
                    return true;
            
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        
        public async Task<bool> EfetivarRegistroPerfilUsuario(Usuario login, string role)
        {
            try
            {
                var usuario = new IdentityUser() { UserName = login.UserName, Email = login.Email};
                var resultado = await _userManager.AddToRoleAsync(usuario, role);

                if (resultado.Succeeded)
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> EfetivarLogout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return true;
            }
            catch 
            {
                return false;            
            }
        }

        public async Task<IList<AuthenticationScheme>> GetAutenticacaoExterna()
        {
            var listaExternalLogin = new List<AuthenticationScheme>();
            var ExternalLogins = ( await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            foreach (var ExternalAuthenticationScheme in ExternalLogins)
            {
                listaExternalLogin.Add(new AuthenticationScheme(ExternalAuthenticationScheme.Name, ExternalAuthenticationScheme.DisplayName, ExternalAuthenticationScheme.HandlerType ));
            }

            return listaExternalLogin;
        }
    }
}
