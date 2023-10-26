using Domain.Entities;
using Domain.Models;

namespace Core.Interface
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuarios>
    {
        UserToken Cadastrar(string nome, string email, string senha, string role);
    }
}
