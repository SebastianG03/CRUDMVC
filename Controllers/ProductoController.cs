using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View(Util.Utils.ListaProducto);
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
