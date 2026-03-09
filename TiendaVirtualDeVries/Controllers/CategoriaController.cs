using Microsoft.AspNetCore.Mvc;
using TiendaVirtualDeVries.Models;

namespace TiendaVirtualDeVries.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var categorias = new List<Categoria>
            {
                new Categoria{ Id = 2, Nombre = "Ropa", Descripcion = "Ropa para damas y caballeros"},
                new Categoria{ Id = 2, Nombre = "Celulares", Descripcion = "Varios tipos de celulares"},
                new Categoria{ Id = 2, Nombre = "Televisores", Descripcion = "Varios tipos de televisores"},
                new Categoria{ Id = 3, Nombre = "", Descripcion = "No definido"}
            };
            return View(categorias);
        }
    }
}