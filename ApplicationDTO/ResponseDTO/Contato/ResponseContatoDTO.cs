using Domain.Entities;

namespace ApplicationDTO.ResponseDTO.Contato
{
    public class ResponseContatoDTO : ResponseBaseDTO
    {
        public List<Contato> Contatos { get; set; }
    }
}
