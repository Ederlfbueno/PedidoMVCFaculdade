using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedido_MVC.Models
{
    [Table("Cidades")]
    public class Cidade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        public string Nome { get; set; }

        public string UF { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
