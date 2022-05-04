using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Models
{
    [Table("Servicos")]
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }

        [Required(ErrorMessage = "Informe a data de entrada!")]
        [Display(Name = "Data Entrada")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ServicoDataEntrada { get; set; }

        [Required(ErrorMessage = "Informe a data de saída!")]
        [Display(Name = "Data Saída")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ServicoDataSaida { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Required(ErrorMessage = "Informe a descrição do serviço!")]
        [Display(Name = "Descrição")]
        public string ServicoDescricao { get; set; }

        [Required(ErrorMessage = "O valor do serviço deve ser informado!")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99 reais!")]
        public double ServicoValor { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Display(Name = "Peças")]
        public string ServicoPecas { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Display(Name = "Observação")]
        public string ServicoObs { get; set; }

        [Display(Name ="Completo?")]
        public bool ServicoCompleto { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
