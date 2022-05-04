using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        
        [StringLength(20, ErrorMessage = "O tamanho máximo é 20 caracteres!")]
        [Required(ErrorMessage = "Informe o nome de usuário!")]
        [Display(Name = "Login")]
        public string UsuarioLogin { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres!")]
        [Required(ErrorMessage = "Informe a senha!")]
        [Display(Name = "Senha")]
        public string UsuarioSenha { get; set; }
        
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Required(ErrorMessage = "Informe um email válido!")]
        [Display(Name = "E-mail")]
        public string UsuarioEmail { get; set; }

        [StringLength(30, ErrorMessage = "O tamanho máximo é 30 caracteres!")]
        [Required(ErrorMessage = "Informe como quer ser chamado!")]
        [Display(Name = "Nome")]
        public string UsuarioNome { get; set; }
    }
}
