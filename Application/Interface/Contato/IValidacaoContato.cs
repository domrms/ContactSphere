using ApplicationDTO.RequestDTO.Contato;

namespace Application.Interface.Contato
{
    public interface IValidacaoContato
    {
        public string ValidaDadosCadastroContato(RequestCadastrarContatoDto cadastrarContatoDto);
    }
}
