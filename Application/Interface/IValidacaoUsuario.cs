using ApplicationDTO.RequestDTO;

namespace Application.Interface
{
    public interface IValidacaoUsuario
    {
        public string ValidaDadosUsuario(RequestUsuarioDTO obj);
    }
}
