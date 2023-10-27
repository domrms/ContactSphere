using ApplicationDTO.ResponseDTO;
using System.Net;

namespace Adapter.Interfaces
{
    public interface IMapperContato
    {
        ResponseBaseDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem);
    }
}
