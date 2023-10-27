using Application.Interface.Usuario;
using ApplicationDTO.RequestDTO.Usuario;
using ApplicationDTO.ResponseDTO.Usuario;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactSphere_API.Controllers.Usuario
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
        [Route("/Cadastrar")]
        [AllowAnonymous]
        public ResponseUsuarioDTO Cadastrar(RequestUsuarioDTO request)
        {
            var retorno = _applicationUsuario.Cadastro(request);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }

        [HttpPost]
        [Route("/Login")]
        [AllowAnonymous]
        public ResponseUsuarioDTO Login(RequestLoginDTO request)
        {
            var retorno = _applicationUsuario.Login(request);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}