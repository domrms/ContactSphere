using ApplicationDTO.RequestDTO.Usuario;

namespace Application.Interface.Usuario
{
    public interface IValidacaoUsuario
    {
        public string ValidaDadosUsuario(RequestUsuarioDto usuarioDTO);

        public string ValidaDadosLogin(RequestLoginDto loginDTO);
    }
}