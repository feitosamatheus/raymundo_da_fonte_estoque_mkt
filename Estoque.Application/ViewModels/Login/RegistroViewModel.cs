using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.ViewModels.Login
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Informe um Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Informe um Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe uma Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string PasswordHash { get; set; }

        public string ReturnUrl { get; set; }
    }
}
