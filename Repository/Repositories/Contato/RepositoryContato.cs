using Core.Interface.Repository.Contato;
using Data;
using Domain.Entities;

namespace Repository.Repositories.Contato
{
    public class RepositoryContato : RepositoryBase<Contato>, IRepositoryContato
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
                Contato contato = new Contato()
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
    }
}
