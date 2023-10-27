using Adapter.Interfaces.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using System.Net;

namespace Adapter.Map.Contato
{
    public class MapperContato : IMapperContato
    {
        public ResponseBaseDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem)
        {
            return new ResponseBaseDTO
            {
                codRetorno = codRetorno,
                mensagem = mensagem
            };
        }

        public ResponseContatoDTO MapperContatoPorIdToDTO(HttpStatusCode codRetorno, string mensagem, List<Domain.Entities.Contatos> ListaContato = null)
        {
            return new ResponseContatoDTO
            {
                codRetorno = codRetorno,
                mensagem = mensagem,
                Contatos = ListaContato
            };
        }
    }
}