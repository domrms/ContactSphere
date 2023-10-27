using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using System.Net;

namespace Adapter.Interfaces.Contato
{
    public interface IMapperContato
    {
        ResponseBaseDto MapperToDTO(HttpStatusCode codRetorno, string mensagem);

        ResponseContatoDto MapperContatoPorIdToDTO(HttpStatusCode codRetorno, string mensagem, List<Domain.Entities.Contatos> ListaContato = null);
    }
}