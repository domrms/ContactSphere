using ApplicationDTO.RequestDTO.Contato;

namespace Application.Interface.Contato
{
    public interface IValidacaoContato
    {
        public string ValidaDadosContato(RequestDadosContatoDto cadastrarContatoDto);

        public string ValidaDadosPorId(RequestContatoIdDTO requestContatoPorIdDTO);
        public string ValidaDadosUpdateContato(RequestUpdateContatoDTO cadastrarContatoDto);
    }
}