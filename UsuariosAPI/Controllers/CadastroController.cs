using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTO;

namespace UsuariosAPI.Controllers
{
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase    
    {
        [HttpPost]    
        public IActionResult CadastrarUsuario(CreateUsuarioDTO usuario)
        {
            return Ok();
        }

    }
}
