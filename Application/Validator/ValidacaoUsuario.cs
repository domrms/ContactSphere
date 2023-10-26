using Adapter.Interfaces;
using Application.Interface;
using ApplicationDTO.RequestDTO;

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
        private const string erroUsuarioNaoCadastrado = "USUÁRIO NÃO CADASTRADO!";
        //TODO: VERIFICAR EMAIL

        public string ValidaDadosUsuario(RequestUsuarioDTO usuarioDTO)
        {
            if (_authenticateService.UsuarioExiste(usuarioDTO.Email)) return erroUsuarioExiste;
            if (usuarioDTO.Role != "ADM" && usuarioDTO.Role != "USR") return erroRoleInvalida;

            return string.Empty;
        }

        public string ValidaDadosLogin(RequestLoginDTO loginDTO)
        {
            if (!_authenticateService.Autenticacao(loginDTO.Email, loginDTO.Senha)) return erroUsuarioNaoCadastrado;

            return string.Empty;
        }
    }
}