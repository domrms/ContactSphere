using ApplicationDTO.RequestDTO.Contato;

namespace Application.Interface.Contato
{
    public interface IValidacaoContato
    {
        public string ValidaDadosContato(RequestDadosContatoDto cadastrarContatoDto);

        public string ValidaDadosPorId(RequestContatoIdDto requestContatoPorIdDTO);

        public string ValidaDadosUpdateContato(RequestUpdateContatoDto cadastrarContatoDto);
    }
}