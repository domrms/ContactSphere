using ApplicationDTO.ResponseDTO;
using System.Net;

namespace Adapter.Interfaces.Contato
{
    public interface IMapperContato
    {
        ResponseBaseDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem);
    }
}
