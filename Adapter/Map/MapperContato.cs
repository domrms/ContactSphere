using Adapter.Interfaces;
using ApplicationDTO.ResponseDTO;
using System.Net;

namespace Adapter.Map
{
    public class MapperContato : IMapperContato
    {
        public ResponseBaseDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem)
        {
            return new ResponseBaseDTO
            {
                codRetorno = codRetorno,
                mensagem = mensagem
            };
        }
    }
}
