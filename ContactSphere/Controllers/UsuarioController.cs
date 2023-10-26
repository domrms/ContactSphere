using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactSphere_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IApplicationUsuario _applicationUsuario;
        public UsuarioController(IApplicationUsuario applicationUsuario)
        {
            _applicationUsuario = applicationUsuario;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/Incluir")]
        public ResponseUsuarioDTO Incluir(RequestUsuarioDTO request)
        {
            var retorno = _applicationUsuario.Cadastro(request);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}
