using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;

namespace Application.Interface.Contato
{
    public interface IApplicationContato
    {
        ResponseBaseDTO Cadastro(RequestCadastrarContatoDto request);
    }
}
