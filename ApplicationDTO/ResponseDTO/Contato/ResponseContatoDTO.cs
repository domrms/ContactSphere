namespace ApplicationDTO.ResponseDTO.Contato
{
    public class ResponseContatoDTO : ResponseBaseDTO
    {
        public List<Domain.Entities.Contatos> Contatos { get; set; }
    }
}