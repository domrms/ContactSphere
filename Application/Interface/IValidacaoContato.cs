using ApplicationDTO.RequestDTO;

namespace Application.Interface
{
    public interface IValidacaoContato
    {
        public string ValidaDadosCadastroContato(RequestCadastrarContatoDto cadastrarContatoDto);
    }
}
