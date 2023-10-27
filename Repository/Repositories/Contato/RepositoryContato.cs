using Core.Interface.Repository.Contato;
using Data;

namespace Repository.Repositories.Contato
{
    public class RepositoryContato : RepositoryBase<Domain.Entities.Contatos>, IRepositoryContato
    {
        private readonly DataContext _context;

        public RepositoryContato(DataContext Context) : base(Context)
        {
            _context = Context;
        }

        public bool CadastrarContato(string nome, string email, string telefone, bool status, int fkIdUsuario)
        {
            try
            {
                Domain.Entities.Contatos contato = new Domain.Entities.Contatos()
                {
                    Nome = nome,
                    Email = email,
                    Telefone = telefone,
                    Status = status,
                    FkIdUsuario = fkIdUsuario
                };
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Domain.Entities.Contatos> BuscaContatoPorId(int id)
        {
            return _context.Contatos.Where(x => x.Id == id && x.Status == true);
        }
    }
}