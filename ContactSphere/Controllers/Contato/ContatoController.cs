using Application.Interface.Contato;
using ApplicationDTO.RequestDTO.Contato;
using ApplicationDTO.ResponseDTO;
using ApplicationDTO.ResponseDTO.Contato;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        [AllowAnonymous]
        [HttpPost]
        [Route("/CadastrarContato")]
        public ResponseBaseDTO Cadastrar(RequestDadosContatoDto requestDadosContatoDto)
        {
            var retorno = _applicationContato.Cadastro(requestDadosContatoDto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/RequestContatoPorId")]
        public ResponseContatoDTO RequestContatoPorId(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.RequestContatoPorId(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/RequestListaContatosUsuario")]
        public ResponseContatoDTO RequestListaContatosUsuario(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.RequestListaContatosUsuario(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/DesativarContato")]
        public ResponseBaseDTO DesativarContato(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            var retorno = _applicationContato.DesativarContato(requestContatoPorIdDTO);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/UpdateContato")]
        public ResponseBaseDTO UpdateContato(RequestUpdateContatoDTO requestDadosContatoDto)
        {
            var retorno = _applicationContato.UpdateContato(requestDadosContatoDto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}