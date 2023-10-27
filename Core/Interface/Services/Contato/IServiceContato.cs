namespace Core.Interface.Services.Contato
{
    public interface IServiceContato : IServiceBase<Domain.Entities.Contatos>
    {
        bool CadastrarContato(string nome, string email, string telefone, bool status, int fkIdUsuario);

        List<Domain.Entities.Contatos> BuscaContatoPorId(int id);

        List<Domain.Entities.Contatos> BuscaContatoPorIdUsuario(int id);

        bool AtualizaStatus(int id);

        bool UpdateContato(int id, string nome, string email, string telefone);
    }
}