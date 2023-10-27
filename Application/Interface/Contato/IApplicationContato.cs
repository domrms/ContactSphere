using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;

namespace Application.Interface.Contato
{
    public interface IApplicationContato
    {
        ResponseBaseDto Cadastro(RequestDadosContatoDto request);

        ResponseContatoDto RequestContatoPorId(RequestContatoIdDto request);

        ResponseContatoDto RequestListaContatosUsuario(RequestContatoIdDto request);

        ResponseBaseDto DesativarContato(RequestContatoIdDto requestContatoPorIdDTO);

        ResponseBaseDto UpdateContato(RequestUpdateContatoDto requestDadosContatoDto);
    }
}