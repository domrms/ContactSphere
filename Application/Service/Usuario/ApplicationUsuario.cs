﻿using Adapter.Interfaces.Usuario;
using Application.Interface.Usuario;
using ApplicationDTO.RequestDTO.Usuario;
using ApplicationDTO.ResponseDTO.Usuario;
using Core.Interface.Services.Usuario;
using Domain.Models;
using System.Net;

namespace Application.Service.Usuario
{
    public class ApplicationUsuario : IApplicationUsuario
    {
        private const string semDados = "NÃO FOI ENCONTRADO NENHUM REGISTRO PARA OS DADOS INFORMADOS";
        private readonly IValidacaoUsuario _validacaoUsuario;
        private readonly IMapperUsuario _mapperUsuario;
        private readonly IServiceUsuario _serviceUsuario;

        public ApplicationUsuario(IServiceUsuario serviceUsuario, IMapperUsuario mapperUsuario, IValidacaoUsuario validacaoUsuario)
        {
            _mapperUsuario = mapperUsuario;
            _validacaoUsuario = validacaoUsuario;
            _serviceUsuario = serviceUsuario;
        }

        public ResponseUsuarioDTO Cadastro(RequestUsuarioDto usuarioDto)
        {
            string mensagem = _validacaoUsuario.ValidaDadosUsuario(usuarioDto);
            if (!string.IsNullOrEmpty(mensagem))
                return _mapperUsuario.MapperToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                UserToken userToken = _serviceUsuario.CadastrarUsuario(usuarioDto.Nome, usuarioDto.Email, usuarioDto.Senha, usuarioDto.Role);
                if (userToken != null)
                    return _mapperUsuario.MapperToDTO(HttpStatusCode.OK, mensagem, userToken);
                else
                    return _mapperUsuario.MapperToDTO(HttpStatusCode.NotFound, semDados);
            }
            catch (Exception erro)
            {
                return _mapperUsuario.MapperToDTO(HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        public ResponseUsuarioDTO Login(RequestLoginDto loginDto)
        {
            string mensagem = _validacaoUsuario.ValidaDadosLogin(loginDto);
            if (!string.IsNullOrEmpty(mensagem))
                return _mapperUsuario.MapperToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                UserToken userToken = _serviceUsuario.RetornaTokenLogin(loginDto.Email);
                if (userToken != null)
                    return _mapperUsuario.MapperToDTO(HttpStatusCode.OK, mensagem, userToken);
                else
                    return _mapperUsuario.MapperToDTO(HttpStatusCode.NotFound, semDados);
            }
            catch (Exception erro)
            {
                return _mapperUsuario.MapperToDTO(HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}