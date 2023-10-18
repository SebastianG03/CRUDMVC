using CRUDMVC.Models;
using CRUDMVC.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;
using System.Net.Http.Headers;

namespace CRUDMVC.Controllers
{
    public class ProductoController : Controller
    {
        static HttpClient client = new HttpClient();

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:5026/api/Producto");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

            // GET: ProductoController
            public async Task<IActionResult> Index()
        {
            Producto? product = null;
            HttpResponseMessage response = await client.GetAsync("http://localhost:5026/api/Producto");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Producto>();
            }
            return View(product);
        }

        // GET: ProductoController/Details/5
        public async Task<IActionResult> Details(int IdProducto)
        {
            string path = "http://localhost:5026/api/Producto/" + IdProducto;
            Producto product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Producto>();
                return View(product);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: ProductoController/Create
        [HttpPost]
        public async Task<Uri> Create(Producto producto) 
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/Producto", producto);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        // GET: ProductoController/Edit/5
        public async Task<IActionResult> Edit(int IdProducto)
        {
            Producto? producto = null;
            HttpResponseMessage response = await client.GetAsync("http://localhost:5026/api/Producto/" + IdProducto);
            if (response.IsSuccessStatusCode)
            {
                producto = await response.Content.ReadAsAsync<Producto>();
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Producto product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{product.IdProducto}", product);
            response.EnsureSuccessStatusCode();
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: ProductoController/Delete/5
        public async Task<IActionResult> Delete(int IdProducto)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{IdProducto}");
            return RedirectToAction("Index");
        }
    }
}
