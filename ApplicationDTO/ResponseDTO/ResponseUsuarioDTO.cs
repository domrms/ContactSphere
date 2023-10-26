using Domain.Models;

namespace ApplicationDTO.ResponseDTO
{
    public class ResponseUsuarioDTO : ResponseBaseDTO
    {
        public UserToken usuarioToken { get; set; }
    }
}