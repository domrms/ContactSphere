using Domain.Entities;

namespace Core.Interface.Services.Contato
{
    public interface IServiceContato : IServiceBase<Contato>
    {
        bool CadastrarContato(string nome, string email, string telefone, bool status, int fkIdUsuario);
    }
}
