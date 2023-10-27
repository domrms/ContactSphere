using Core.Interface.Repository.Contato;
using Core.Interface.Services.Contato;

namespace Services.Services.Contato
{
    public class ServiceContato : ServiceBase<Domain.Entities.Contatos>, IServiceContato
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

        public List<Domain.Entities.Contatos> BuscaContatoPorId(int id)
        {
            return _repositoryContato.BuscaContatoPorId(id).ToList();
        }
        public List<Domain.Entities.Contatos> BuscaContatoPorIdUsuario(int id)
        {
            return _repositoryContato.BuscaContatoPorIdUsuario(id).ToList();
        }
        public bool AtualizaStatus(int id)
        {
            return _repositoryContato.AtualizaStatus(id);
        }
        public bool UpdateContato(int id,string nome, string email, string telefone)
        {
            return _repositoryContato.UpdateContato(id,nome, email, telefone);
        }
    }
}
