using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Models
{
    [Table("Carros")]
    public class Carro
    {
        [Key]
        public int CarroId { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres!")]
        [Required(ErrorMessage = "Informe o marca do veículo!")]
        [Display(Name = "Marca")]
        public string CarroMarca { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres!")]
        [Required(ErrorMessage = "Informe o modelo do veículo!")]
        [Display(Name = "Modelo")]
        public string CarroModelo { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Display(Name = "Observação")]
        public string CarroObs { get; set; }
    }
}
