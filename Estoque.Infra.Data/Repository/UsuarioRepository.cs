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

        public async Task<bool> EfetivarLogin(Usuario model) {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = _signInManager.PasswordSignInAsync(user, model.PasswordHash, false, false);

                if (result.Result.Succeeded)
                {
                    return true;
                }
                return false;
            }
            return false;
        }    


    }
}
