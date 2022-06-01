using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Models
{
    [Table("Caixa")]
    public class Caixa
    {
        [Key]
        public int CaixaId { get; set; }

        [Required(ErrorMessage = "Informe a data de validade!")]
        [Display(Name = "Data de Validade")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = true)]
        public DateTime HoraAbriu { get; set; }

        [Required(ErrorMessage = "Informe a data de validade!")]
        [Display(Name = "Data de Validade")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = true)]
        public DateTime HoraFechou { get; set; }

        [Display(Name = "Saldo")]
        [Column(TypeName = "decimal(10,2)")]
        public double Saldo { get; set; }

        public int UsuarioId { get; set; }
    }
}
