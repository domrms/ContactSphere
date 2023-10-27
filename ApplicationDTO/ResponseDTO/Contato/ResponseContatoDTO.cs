namespace ApplicationDTO.ResponseDTO.Contato
{
    public class ResponseContatoDto : ResponseBaseDto
    {
        public List<Domain.Entities.Contatos> Contatos { get; set; }
    }
}