using Adapter.Interfaces;
using Core.Interface;
using Data;
using Domain.Entities;
using Domain.Models;

namespace Repository.Repositories
{
    public class RepositoryUsuario : RepositoryBase<Usuarios>, IRepositoryUsuario
    {
        private readonly DataContext _context;
        private readonly IAuthenticateService _authenticateService;

        public RepositoryUsuario(DataContext Context, IAuthenticateService authenticateService) : base(Context)
        {
            _context = Context;
            _authenticateService = authenticateService;
        }

        public UserToken Cadastrar(string nome, string email, string senha, string role)
        {
            Usuarios usuario = new Usuarios()
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                Role = role
            };
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            var token = _authenticateService.GenerateToken(email, role);
            return new UserToken
            {
                Token = token
            };
        }

        public UserToken RetornaTokenLogin(string email)
        {
            var role = _context.Usuarios.Where(x => x.Email.ToLower() == email.ToLower()).Select(x => x.Role).FirstOrDefault();

            var token = _authenticateService.GenerateToken(email, role);
            return new UserToken
            {
                Token = token
            };
        }
    }
}