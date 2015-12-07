using System.Data.Entity;

public class DataContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public DataContext() : base("name=DataContext")
    {
    }

    public DbSet<Pedido_MVC.Models.Cidade> Cidades { get; set; }

    public DbSet<Pedido_MVC.Models.Produto> Produtos { get; set; }

    public DbSet<Pedido_MVC.Models.Cliente> Clientes { get; set; }

    public DbSet<Pedido_MVC.Models.Usuario> Usuarios { get; set; }

    public DbSet<Pedido_MVC.Models.Pedido> Pedidoes { get; set; }

    public DbSet<Pedido_MVC.Models.Pedido> PedidoProdutos { get; set; }

    public System.Data.Entity.DbSet<Pedido_MVC.Models.PedidoProduto> PedidoProdutoes { get; set; }
}
