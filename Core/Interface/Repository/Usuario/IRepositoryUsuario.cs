using Domain.Entities;
using Domain.Models;

namespace Core.Interface.Repository.Usuario
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario>
    {
        UserToken Cadastrar(string nome, string email, string senha, string role);

        UserToken RetornaTokenLogin(string email);
    }
}