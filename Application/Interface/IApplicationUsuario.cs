using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;

namespace Application.Interface
{
    public interface IApplicationUsuario
    {
        ResponseUsuarioDTO Cadastro(RequestUsuarioDTO request);
    }
}
