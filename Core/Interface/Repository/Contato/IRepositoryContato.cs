namespace Core.Interface.Repository.Contato
{
    public interface IRepositoryContato : IRepositoryBase<Domain.Entities.Contatos>
    {
        bool CadastrarContato(string nome, string email, string telefone, bool status, int fkIdUsuario);

        IQueryable<Domain.Entities.Contatos> BuscaContatoPorId(int id);
        IQueryable<Domain.Entities.Contatos> BuscaContatoPorIdUsuario(int id);
    }
}