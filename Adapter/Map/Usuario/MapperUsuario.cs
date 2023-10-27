using Adapter.Interfaces.Usuario;
using ApplicationDTO.ResponseDTO.Usuario;
using Domain.Models;
using System.Net;

namespace Adapter.Map.Usuario
{
    public class MapperUsuario : IMapperUsuario
    {
        public ResponseUsuarioDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem, UserToken usuarioToken = null)
        {
            return new ResponseUsuarioDTO
            {
                CodRetorno = codRetorno,
                Mensagem = mensagem,
                UsuarioToken = usuarioToken
            };
        }
    }
}