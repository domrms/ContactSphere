using ApplicationDTO.RequestDTO;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Interface
{
    public interface IApplicationUsuario
    {
        Task<ActionResult<UserToken>> Incluir(RequestUsuarioDTO request);
    }
}
