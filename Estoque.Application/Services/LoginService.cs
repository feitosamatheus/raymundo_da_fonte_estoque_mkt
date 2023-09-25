using AutoMapper;
using Estoque.Application.ViewModels.Login;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Application.Services
{
    public class LoginService
    {
        private IUsuarioRepository _userRepository;
        private IInfraRepository _infraRepository;
        private readonly IMapper _maper;

        public LoginService(IUsuarioRepository userRepository, IInfraRepository infraRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _infraRepository = infraRepository;
            _maper = mapper;

        }

        public async Task<bool> EfetivarLogin(LoginViewModel login)
        {
            var convercao = _maper.Map<Usuario>(login);
            var resultadoLogin = await _userRepository.EfetivarLogin(convercao);

            return resultadoLogin; 
        }
    }
}
