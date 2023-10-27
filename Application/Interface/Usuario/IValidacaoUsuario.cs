using ApplicationDTO.RequestDTO.Usuario;

namespace Application.Interface.Usuario
{
    public interface IValidacaoUsuario
    {
        public string ValidaDadosUsuario(RequestUsuarioDTO usuarioDTO);

        public string ValidaDadosLogin(RequestLoginDTO loginDTO);
    }
}