using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;

namespace Application.Interface
{
    public interface IApplicationContato
    {
        ResponseBaseDTO Cadastro(RequestCadastrarContatoDto request);
    }
}
