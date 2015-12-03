using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedido_MVC.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [StringLength(100, ErrorMessage = "Digite no maximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(100, ErrorMessage = "Digite no maximo 100 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [StringLength(10)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória.")]        
        public int CidadeId { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório.")]        
        public int UsuarioId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        public virtual Cidade Cidade { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
