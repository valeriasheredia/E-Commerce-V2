using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductosService _service;
        public ProductosController(IProductosService service)
        {
            _service = service;
        }
        // GET: ProductosController
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Linea, m => m.Caracteristica);
            return View(data);
        }

        // GET: ProductosController/Details/5
        public async Task< ActionResult> Details(int id)
        {
            var productoDetalle = await _service.GetProductoByIdAsync(id);

            return View(productoDetalle);
        }

        // GET: ProductosController/Create
        public async Task<ActionResult> Create()
        {
            var productoDropdownsData = await _service.GetNewProductoDropdownsValues();
            ViewBag.Caracteristicas = new SelectList(productoDropdownsData.Caracteristicas, "Id", "Nombre");
            ViewBag.Lineas = new SelectList(productoDropdownsData.Lineas, "Id", "Nombre");
            return View();
        }

        // POST: ProductosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
