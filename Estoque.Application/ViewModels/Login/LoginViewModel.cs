using System.ComponentModel.DataAnnotations;

namespace Estoque.Application.ViewModels.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe um Nome")]
        [Display(Name ="Nome")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe uma Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string PasswordHash { get; set; }
        
        public string ReturnUrl { get; set; }
    }
}
