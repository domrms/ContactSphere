using Core.Interface;
using Core.Interface.Services;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ServiceUsuario : ServiceBase<Usuarios>, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }
        public UserToken InserirUsuario(string nome, string email, string senha, string role)
        {
            return _repositoryUsuario.Cadastrar(nome, email, senha, role);    
        }
    }
}
