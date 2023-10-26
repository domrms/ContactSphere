using Adapter.Interfaces;
using ApplicationDTO.ResponseDTO;
using Domain.Models;
using System.Net;

namespace Adapter.Map
{
    public class MapperUsuario : IMapperUsuario
    {
        public ResponseUsuarioDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem, UserToken usuarioToken = null)
        {
            return new ResponseUsuarioDTO
            {
                codRetorno = codRetorno,
                mensagem = mensagem,
                usuarioToken = usuarioToken
            };
        }
    }
}
