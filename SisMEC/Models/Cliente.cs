using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres!")]
        [Required(ErrorMessage = "Informe nome do cliente!")]
        [Display(Name = "Nome")]
        public string ClienteNome { get; set; }

        [StringLength(11, ErrorMessage = "O tamanho máximo é 11 caracteres!")]
        [Required(ErrorMessage = "Informe CPF do cliente!")]
        [Display(Name = "CPF")]
        public string ClienteCPF { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres!")]
        [Required(ErrorMessage = "Informe e-mail do cliente!")]
        [Display(Name = "E-mail")]
        public string ClienteEmail { get; set; }

        [StringLength(11, ErrorMessage = "O tamanho máximo é 11 caracteres!")]
        [Required(ErrorMessage = "Informe telefone do cliente!")]
        [Display(Name = "Telefone")]
        public string ClienteTelefone { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Required(ErrorMessage = "Informe endereço do cliente!")]
        [Display(Name = "Endereço")]
        public string ClienteEndereco { get; set; }
        public int CarroId { get; set; }
        public virtual Carro Carro { get; set; }

        public List<Carro> ClienteCarros { get; set; }
    }
}
