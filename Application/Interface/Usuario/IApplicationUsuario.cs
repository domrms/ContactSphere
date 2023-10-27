using ApplicationDTO.RequestDTO.Usuario;
using ApplicationDTO.ResponseDTO.Usuario;

namespace Application.Interface.Usuario
{
    public interface IApplicationUsuario
    {
        ResponseUsuarioDTO Cadastro(RequestUsuarioDto request);

        ResponseUsuarioDTO Login(RequestLoginDto request);
    }
}