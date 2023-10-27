using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactSphere_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        private readonly IApplicationContato _applicationContato;

        public ContatoController(IApplicationContato applicationContato)
        {
            _applicationContato = applicationContato;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/CadastrarContato")]
        public ResponseBaseDTO Cadastrar(RequestCadastrarContatoDto request)
        {
            var retorno = _applicationContato.Cadastro(request);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}
