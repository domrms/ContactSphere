using Application.Interface;
using ApplicationDTO.RequestDTO;
using Utils;
using Utils._4._1_Interface;

namespace Application.Validator
{
    public class ValidacaoUsuario : IValidacaoUsuario
    {
        private readonly IAuthenticateService _authenticateService;

        public ValidacaoUsuario(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        private const string erroUsuarioExiste = "O USUÁRIO JÁ EXISTE!";
        private const string erroRoleInvalida = "A ROLE DEVE SER ADM OU USR!";

        public string ValidaDadosUsuarioAsync(RequestUsuarioDTO usuarioDTO)
        {
            if (_authenticateService.UsuarioExiste(usuarioDTO.Email)) return erroUsuarioExiste;
            if (usuarioDTO.Role != "ADM" && usuarioDTO.Role != "USR") return erroRoleInvalida;

            return string.Empty;
        }
    }
}
