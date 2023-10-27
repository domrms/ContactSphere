using Domain.Entities;

namespace ApplicationDTO.ResponseDTO
{
    public class ResponseContatoDTO : ResponseBaseDTO
    {
        public List<Contato> Contatos { get; set; }
    }
}
