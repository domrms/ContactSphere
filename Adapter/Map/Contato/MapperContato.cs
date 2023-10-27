using Adapter.Interfaces.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using System.Net;

namespace Adapter.Map.Contato
{
    public class MapperContato : IMapperContato
    {
        public ResponseBaseDto MapperToDTO(HttpStatusCode codRetorno, string mensagem)
        {
            return new ResponseBaseDto
            {
                CodRetorno = codRetorno,
                Mensagem = mensagem
            };
        }

        public ResponseContatoDto MapperContatoPorIdToDTO(HttpStatusCode codRetorno, string mensagem, List<Domain.Entities.Contatos> ListaContato = null)
        {
            return new ResponseContatoDto
            {
                CodRetorno = codRetorno,
                Mensagem = mensagem,
                Contatos = ListaContato
            };
        }
    }
}