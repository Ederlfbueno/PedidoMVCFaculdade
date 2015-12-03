using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedido_MVC.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome de login é obrigatório.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Digite no mínimo 3 e no máximo 20 caracteres.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "a senha é obrigatória.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Digite no mínimo 6 e no máximo 20 caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public string Grupo { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
