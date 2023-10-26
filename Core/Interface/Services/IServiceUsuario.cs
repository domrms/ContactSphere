using Domain.Entities;
using Domain.Models;

namespace Core.Interface.Services
{
    public interface IServiceUsuario : IServiceBase<Usuarios>
    {
        UserToken InserirUsuario(string nome, string email, string senha, string role);
    }
}
