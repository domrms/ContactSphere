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
        public ResponseBaseDTO Cadastrar(RequestDadosContatoDto requestDadosContatoDto)
        {
            var retorno = _applicationContato.Cadastro(requestDadosContatoDto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/RequestContatoPorId")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseContatoDTO RequestContatoPorId(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.RequestContatoPorId(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/RequestListaContatosUsuario")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseContatoDTO RequestListaContatosUsuario(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.RequestListaContatosUsuario(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/DesativarContato")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseBaseDTO DesativarContato(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.DesativarContato(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/UpdateContato")]
        [Authorize(Roles = "ADM", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
        public ResponseBaseDTO UpdateContato(RequestUpdateContatoDTO requestDadosContatoDto)
        {
            if (User.IsInRole("ADM"))
            {
                var Unauthorized = _applicationContato.UpdateContato(requestDadosContatoDto);
                HttpContext.Response.StatusCode = (int)Unauthorized.codRetorno;
                return Unauthorized;
            }
            else
            {
                return new ResponseBaseDTO
                {
                    codRetorno = HttpStatusCode.Unauthorized,
                    mensagem = ""
                };
            }
        }
    }
}