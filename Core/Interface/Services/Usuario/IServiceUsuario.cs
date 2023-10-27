using Domain.Entities;
using Domain.Models;

namespace Core.Interface.Services.Usuario
{
    public interface IServiceUsuario : IServiceBase<Usuario>
    {
        UserToken CadastrarUsuario(string nome, string email, string senha, string role);

        UserToken RetornaTokenLogin(string email);
    }
}