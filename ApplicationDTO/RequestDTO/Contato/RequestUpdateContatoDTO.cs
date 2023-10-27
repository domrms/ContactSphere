namespace ApplicationDTO.RequestDTO.Contato
{
    public class RequestUpdateContatoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}