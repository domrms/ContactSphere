using Core.Interface;
using Core.Interface.Services;
using Domain.Entities;
using Domain.Models;

namespace Services.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public UserToken CadastrarUsuario(string nome, string email, string senha, string role)
        {
            return _repositoryUsuario.Cadastrar(nome, email, senha, role);
        }

        public UserToken RetornaTokenLogin(string email)
        {
            return _repositoryUsuario.RetornaTokenLogin(email);
        }
    }
}