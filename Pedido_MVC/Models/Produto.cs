using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedido_MVC.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        public Int64 Numero { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório.")]
        [Range(typeof(decimal), "0", "999999999", ErrorMessage = "O campo Preço deve conter um valor numérico positivo. Entre 0 e 999999999.")]        
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A data de validade é obrigatória.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataValidade { get; set; }

        public virtual ICollection<PedidoProduto> PedidoProdutos { get; set; }
    }
}
