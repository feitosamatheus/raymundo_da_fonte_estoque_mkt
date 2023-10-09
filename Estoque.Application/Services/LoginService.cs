﻿using AutoMapper;
using Estoque.Application.Interfaces;
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
    public class LoginService : ILoginService
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
            if (login == null)
                return false;

            var convercao = _maper.Map<Usuario>(login);
            var resultadoLogin = await _userRepository.EfetivarLogin(convercao);
            return resultadoLogin; 
        }

        public async Task<bool> EfetivarRegistro(LoginViewModel login)
        {
            var convercao = _maper.Map<Usuario>(login);
            var resultadoRegistro = await _userRepository.EfetivarRegistro(convercao);

            if (resultadoRegistro)
                await EfetivarRegistroPerfilUsuario(login, "Nivel 1");

            return resultadoRegistro;
        }

        public async Task<bool> EfetivarRegistroPerfilUsuario(LoginViewModel login, string role)
        {
            var convercao = _maper.Map<Usuario>(login);
            var resultadoRegistroPerfil = await _userRepository.EfetivarRegistroPerfilUsuario(convercao, role);

            return resultadoRegistroPerfil;
        }

        public async Task<bool> EfetivarLogout()
        {
            var resultadoLogout = await _userRepository.EfetivarLogout();
            return resultadoLogout; 
        }

        public AuthenticationScheme GetAutenticacaoExterna()
        {

        }
    }
}
