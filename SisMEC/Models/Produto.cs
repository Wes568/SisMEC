using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres!")]
        [Required(ErrorMessage = "Informe nome do produto!")]
        [Display(Name = "Nome")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "A quantidade de produtos deve ser informada!")]
        [Display(Name = "Quantidade")]
        [Column(TypeName = "decimal(10)")]
        [Range(1, 1000, ErrorMessage = "A quantidade deve estar entre 1 e 1000!")]
        public int ProdutoQuantidade { get; set; }

        [Required(ErrorMessage = "O preço do produto deve ser informado!")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99 reais!")]
        public int ProdutoValor { get; set; }

        [Required(ErrorMessage = "Informe a data de validade!")]
        [Display(Name = "Data de Validade")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ProdutoDataValidade { get; set; }
    }
}
