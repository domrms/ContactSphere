using Domain.Entities;

namespace Core.Interface.Repository
{
    public interface IRepositoryContato : IRepositoryBase<Contato>
    {
        bool CadastrarContato(string nome, string email, string telefone, bool status, int fkIdUsuario);
    }
}
