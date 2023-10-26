using Adapter.Interfaces;
using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Core.Interface.Services;
using Domain.Models;
using System.Net;

namespace Application.Service
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

        public ResponseUsuarioDTO Cadastro(RequestUsuarioDTO usuarioDto)
        {
            string mensagem = _validacaoUsuario.ValidaDadosUsuarioAsync(usuarioDto);
            if (!string.IsNullOrEmpty(mensagem))
                return _mapperUsuario.MapperToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                UserToken userToken = _serviceUsuario.InserirUsuario(usuarioDto.Nome ,usuarioDto.Email, usuarioDto.Senha, usuarioDto.Role);
                if (userToken !=  null)
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
