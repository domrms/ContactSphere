using Core.Interface.Repository;
using Core.Interface.Services;
using Domain.Entities;

namespace Services.Services
{
    public class ServiceContato : ServiceBase<Contato>, IServiceContato
    {
        private readonly IRepositoryContato _repositoryContato;

        public ServiceContato(IRepositoryContato repositoryContato) : base(repositoryContato)
        {
            _repositoryContato = repositoryContato;
        }

        public bool CadastrarContato(string nome, string email, string telefone,bool status, int fkIdUsuario)
        {
            return _repositoryContato.CadastrarContato(nome, email, telefone, status, fkIdUsuario);
        }
    }
}
