using Adapter.Interfaces.Contato;
using Application.Interface.Contato;
using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using Core.Interface.Services.Contato;
using System.Net;

namespace Application.Service.Contato
{
    public class ApplicationContato : IApplicationContato
    {
        private const string semDados = "NÃO FOI ENCONTRADO NENHUM REGISTRO PARA OS DADOS INFORMADOS";
        private readonly IValidacaoContato _validacaoContato;
        private readonly IMapperContato _mapperContato;
        private readonly IServiceContato _serviceContato;

        public ApplicationContato(IServiceContato serviceContato, IMapperContato mapperContato, IValidacaoContato validacaoContato)
        {
            _mapperContato = mapperContato;
            _validacaoContato = validacaoContato;
            _serviceContato = serviceContato;
        }

        public ResponseBaseDTO Cadastro(RequestCadastrarContatoDto cadastrarContatoDto)
        {
            string mensagem = _validacaoContato.ValidaDadosCadastroContato(cadastrarContatoDto);
            if (!string.IsNullOrEmpty(mensagem))
                return _mapperContato.MapperToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                bool cadastro = _serviceContato.CadastrarContato(cadastrarContatoDto.Nome, cadastrarContatoDto.Email, cadastrarContatoDto.Telefone, cadastrarContatoDto.Status, cadastrarContatoDto.FkIdUsuario);
                if (cadastro)
                    return _mapperContato.MapperToDTO(HttpStatusCode.OK, mensagem);
                else
                    return _mapperContato.MapperToDTO(HttpStatusCode.NotFound, semDados);
            }
            catch (Exception erro)
            {
                return _mapperContato.MapperToDTO(HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        public ResponseContatoDTO RequestContatoPorId(RequestContatoPorIdDTO requestContatoPorIdDTO)
        {
            string mensagem = _validacaoContato.ValidaDadosRequestContatoPorId(requestContatoPorIdDTO);
            if (!string.IsNullOrEmpty(mensagem))
                return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                List<Domain.Entities.Contatos> lista = _serviceContato.BuscaContatoPorId(requestContatoPorIdDTO.Id).ToList();
                if (lista.Count > 0)
                    return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.OK, mensagem, lista);
                else
                    return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.NotFound, semDados);
            }
            catch (Exception erro)
            {
                return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        public ResponseContatoDTO RequestListaContatosUsuario(RequestContatoPorIdDTO requestContatoPorIdDTO)
        {
            string mensagem = _validacaoContato.ValidaDadosRequestContatoPorId(requestContatoPorIdDTO);
            if (!string.IsNullOrEmpty(mensagem))
                return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                List<Domain.Entities.Contatos> lista = _serviceContato.BuscaContatoPorIdUsuario(requestContatoPorIdDTO.Id).ToList();
                if (lista.Count > 0)
                    return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.OK, mensagem, lista);
                else
                    return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.NotFound, semDados);
            }
            catch (Exception erro)
            {
                return _mapperContato.MapperContatoPorIdToDTO(HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}