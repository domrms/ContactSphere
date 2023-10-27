using System.Net;

namespace ApplicationDTO.ResponseDTO
{
    public class ResponseBaseDto
    {
        public HttpStatusCode CodRetorno { get; set; }
        public string Mensagem { get; set; }
    }
}