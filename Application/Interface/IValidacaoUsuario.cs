using ApplicationDTO.RequestDTO;

namespace Application.Interface
{
    public interface IValidacaoUsuario
    {
       public string ValidaDadosUsuarioAsync(RequestUsuarioDTO usuarioDTO);
    }
}
