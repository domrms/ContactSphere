using Core.Interface.Repository.Contato;
using Core.Interface.Services.Contato;
using Domain.Entities;

namespace Services.Services.Contato
{
    public class ServiceContato : ServiceBase<Contato>, IServiceContato
    {
        private readonly IRepositoryContato _repositoryContato;

        public ServiceContato(IRepositoryContato repositoryContato) : base(repositoryContato)
        {
            _repositoryContato = repositoryContato;
        }

        public bool CadastrarContato(string nome, string email, string telefone, bool status, int fkIdUsuario)
        {
            return _repositoryContato.CadastrarContato(nome, email, telefone, status, fkIdUsuario);
        }
    }
}
