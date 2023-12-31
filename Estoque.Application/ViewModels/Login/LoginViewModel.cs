﻿using Estoque.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Estoque.Application.ViewModels.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe um Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe uma Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string PasswordHash { get; set; }
        
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogin { get; set; }

    }
}
