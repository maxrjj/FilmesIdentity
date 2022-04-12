using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.DTO
{
    public class CreateUsuarioDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Senha nao bate")]
        public string RePassword { get; set; }
    }
}
