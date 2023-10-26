using Microsoft.EntityFrameworkCore;

namespace Utils._4._1_Interface
{
    public interface IAuthenticateService
    {
        public bool AutenticacaoAsync(string email, string senha);
        public bool UsuarioExiste(string email);
        public string GenerateToken(string email, string role);
    }
}
