using ApplicationDTO.RequestDTO;

namespace Application.Interface
{
    public interface IValidacaoUsuario
    {
       public string ValidaDadosUsuario(RequestUsuarioDTO usuarioDTO);
       public string ValidaDadosLogin(RequestLoginDTO loginDTO);
    }
}
