using System.Net;

namespace ApplicationDTO.ResponseDTO
{
    public class ResponseBaseDTO
    {
        public HttpStatusCode codRetorno { get; set; }
        public string mensagem { get; set;}
    }
}
