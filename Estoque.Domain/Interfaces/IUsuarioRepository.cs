using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<bool> EfetivarLogin(Usuario model);
        Task<bool> EfetivarRegistro(Usuario login);
        Task<bool> EfetivarRegistroPerfilUsuario(Usuario login, string role);
        Task<bool> EfetivarLogout();
    }
}
