using ApplicationDTO.ResponseDTO;
using Domain.Models;
using System.Net;

namespace Adapter.Interfaces
{
    public interface IMapperUsuario
    {
        ResponseUsuarioDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem, UserToken usuarioToken = null);
    }
}