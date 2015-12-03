using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedido_MVC.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A data do pedido é obrigatória.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataPedido { get; set; }

        [Required(ErrorMessage = "O cliente é obrigatório.")]    
        public int ClientId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime PrevisaoEntrega { get; set; }

        public decimal Total { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<PedidoProduto> PedidoProdutos { get; set; }
    }
}
