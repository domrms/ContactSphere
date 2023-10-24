using Application.Interface;
using ApplicationDTO.RequestDTO;
using Domain.Models;
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

        [HttpPost]
        [Route("/Usuario")]
        public async Task<ActionResult<UserToken>> Incluir(RequestUsuarioDTO request)
        {
            var retorno = _applicationUsuario.IncluirUsuario(request);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}
