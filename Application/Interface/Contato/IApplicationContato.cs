using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;

namespace Application.Interface.Contato
{
    public interface IApplicationContato
    {
        ResponseBaseDTO Cadastro(RequestDadosContatoDto request);

        ResponseContatoDTO RequestContatoPorId(RequestContatoIdDTO request);
        ResponseContatoDTO RequestListaContatosUsuario(RequestContatoIdDTO request);
        ResponseBaseDTO DesativarContato(RequestContatoIdDTO requestContatoPorIdDTO);
        ResponseBaseDTO UpdateContato(RequestUpdateContatoDTO requestDadosContatoDto);
    }
}