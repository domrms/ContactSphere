namespace ApplicationDTO.RequestDTO.Contato
{
    public class RequestCadastrarContatoDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Status { get; set; }
        public int FkIdUsuario { get; set; }
    }
}
