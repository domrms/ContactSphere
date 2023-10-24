using Application.Interface;
using ApplicationDTO.RequestDTO;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<ActionResult<UserToken>> Incluir(RequestUsuarioDTO request)
        {
            string mensagem = _validacaoUsuario.ValidaDadosUsuario(obj);
            if (!mensagem.Equals(string.Empty))
                return _mapperUsuario.MapperToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                List<vsUsuario> lista = _serviceUsuario.BuscarUsuario(obj.idRequisicao).ToList();
                if (lista.Count() > 0)
                    return _mapperUsuario.MapperToDTO(HttpStatusCode.OK, mensagem, lista);
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
