namespace ApplicationDTO.RequestDTO
{
    public class RequestUsuarioDTO
    {
        public long Id { get; private set; }
        public string Username { get; private set; }
        public string Senha { get; private set; }
        public string Role { get; private set; }
    }
}
