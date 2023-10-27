using Domain.Models;

namespace ApplicationDTO.ResponseDTO.Usuario
{
    public class ResponseUsuarioDTO : ResponseBaseDto
    {
        public UserToken UsuarioToken { get; set; }
    }
}