using FluentResults;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase    
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]    
        public IActionResult CadastrarUsuario(CreateUsuarioDTO createDto)
        {
            Result resultado = _cadastroService.CadastrarUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok();
        }

    }
}
