using CRUDMVC.Models;
using CRUDMVC.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public IActionResult Index()
        {
            return View(Utils.ListaProducto);
        }

        // GET: ProductoController/Details/5
        public IActionResult Details(int id)
        {
            return View(Utils.ListaProducto);
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: ProductoController/Create
        [HttpPost]
        public IActionResult Create(Producto producto) 
        {
            int id = Utils.ListaProducto.Count() + 1;
            Utils.ListaProducto.Add(producto);
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Edit/5
        public IActionResult Edit(int IdProducto)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Delete/5
        public IActionResult Delete(int IdProducto)
        {
            Producto producto = Utils.ListaProducto.Find(x =>  x.IdProducto == IdProducto);
            if (producto != null) 
            {
                Utils.ListaProducto.Remove(producto);
            }
            return RedirectToAction("Index");
        }
    }
}
