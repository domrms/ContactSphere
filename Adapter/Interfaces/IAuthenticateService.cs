namespace Adapter.Interfaces
{
    public interface IAuthenticateService
    {
        public bool Autenticacao(string email, string senha);

        public bool UsuarioExiste(string email);

        public string GenerateToken(string email, string role);
    }
}