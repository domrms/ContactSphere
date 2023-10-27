using Application.Interface.Contato;
using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ContactSphere_API.Controllers.Contato
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

        [HttpPost]
        [Route("/CadastrarContato")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseBaseDto Cadastrar(RequestDadosContatoDto requestDadosContatoDto)
        {
            var retorno = _applicationContato.Cadastro(requestDadosContatoDto);
            HttpContext.Response.StatusCode = (int)retorno.CodRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/RequestContatoPorId")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseContatoDto RequestContatoPorId(RequestContatoIdDto requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.RequestContatoPorId(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.CodRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/RequestListaContatosUsuario")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseContatoDto RequestListaContatosUsuario(RequestContatoIdDto requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.RequestListaContatosUsuario(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.CodRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/DesativarContato")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseBaseDto DesativarContato(RequestContatoIdDto requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.DesativarContato(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.CodRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/UpdateContato")]
        [Authorize(Roles = "ADM", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseBaseDto UpdateContato(RequestUpdateContatoDto requestDadosContatoDto)
        {
            if (User.IsInRole("ADM"))
            {
                var Unauthorized = _applicationContato.UpdateContato(requestDadosContatoDto);
                HttpContext.Response.StatusCode = (int)Unauthorized.CodRetorno;
                return Unauthorized;
            }
            else
            {
                return new ResponseBaseDto
                {
                    CodRetorno = HttpStatusCode.Unauthorized,
                    Mensagem = ""
                };
            }
        }
    }
}