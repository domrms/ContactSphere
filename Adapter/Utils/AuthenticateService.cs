using Adapter.Interfaces;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Adapter.Utils
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public AuthenticateService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public bool Autenticacao(string email, string senha)
        {
            var usuario = _context.Usuarios.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
            if (usuario == null) return false;
            var autenticacao = _context.Usuarios.Where(x => x.Senha.ToLower() == senha.ToLower()).FirstOrDefault();
            if (autenticacao == null) return false;

            return true;
        }

        public bool UsuarioExiste(string email)
        {
            var usuario = _context.Usuarios.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
            if (usuario == null) return false;

            return true;
        }


        public string GenerateToken(string email, string role)
        {
            var claims = new List<Claim>
{
    new Claim("email", email),
    new Claim("role", role),
    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
};

            var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddMinutes(10);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: credentials
            );
            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);

            return "Bearer " + stringToken;
        }

    }
}