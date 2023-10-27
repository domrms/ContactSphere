using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;

namespace Application.Interface.Contato
{
    public interface IApplicationContato
    {
        ResponseBaseDTO Cadastro(RequestCadastrarContatoDto request);

        ResponseContatoDTO RequestContatoPorId(RequestContatoPorIdDTO request);
        ResponseContatoDTO RequestListaContatosUsuario(RequestContatoPorIdDTO request);
    }
}