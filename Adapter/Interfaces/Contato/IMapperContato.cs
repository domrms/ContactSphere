using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using System.Net;

namespace Adapter.Interfaces.Contato
{
    public interface IMapperContato
    {
        ResponseBaseDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem);

        ResponseContatoDTO MapperContatoPorIdToDTO(HttpStatusCode codRetorno, string mensagem, List<Domain.Entities.Contatos> ListaContato = null);
    }
}