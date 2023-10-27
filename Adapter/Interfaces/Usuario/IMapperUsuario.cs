using ApplicationDTO.ResponseDTO.Usuario;
using Domain.Models;
using System.Net;

namespace Adapter.Interfaces.Usuario
{
    public interface IMapperUsuario
    {
        ResponseUsuarioDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem, UserToken usuarioToken = null);
    }
}