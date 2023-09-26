using Estoque.Application.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.Interfaces
{
    public interface ILoginService
    {
        Task<bool> EfetivarLogin(LoginViewModel login);
        Task<bool> EfetivarRegistro(LoginViewModel login);
        Task<bool> EfetivarLogout();
    }
}
