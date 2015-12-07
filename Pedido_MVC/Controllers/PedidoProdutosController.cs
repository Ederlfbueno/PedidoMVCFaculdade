using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;

namespace Pedido_MVC.Controllers
{
    public class PedidoProdutosController : Controller
    {
        DataContext db = new DataContext(); 
        public ActionResult ListarItens(int id)
        {
            var lista = db.PedidoProdutos.Where(m => m.Id == id);
            ViewBag.Pedido = id;
            return PartialView(lista);
        }
    }
}