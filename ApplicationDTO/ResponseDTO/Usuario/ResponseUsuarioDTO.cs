using Domain.Models;

namespace ApplicationDTO.ResponseDTO.Usuario
{
    public class ResponseUsuarioDTO : ResponseBaseDTO
    {
        public UserToken usuarioToken { get; set; }
    }
}