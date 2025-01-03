using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFilmesLibrary.Dtos
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatorio")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo é 50 caracteres")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "O nome de usuário é obrigatorio")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo é 50 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatorio")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo é 50 caracteres")]
        public string Password { get; set; }
    }
}
