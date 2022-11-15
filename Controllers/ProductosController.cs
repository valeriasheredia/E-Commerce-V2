using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private readonly IProductosService _service;
        public ProductosController(IProductosService service)
        {
            _service = service;
        }

        // GET: ProductosController

        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Linea, m => m.Caracteristica);
            return View(data);
        }

        // GET: ProductosController

        [AllowAnonymous]
        public async Task<ActionResult> Filter(string searchString)
        {
            var data = await _service.GetAllAsync(n => n.Linea, m => m.Caracteristica);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = data.Where(n => n.Nombre.Contains(searchString) || n.Descripcion1.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }            
            return View("Index", data);
        }

        // GET: ProductosController/Details/5

        [AllowAnonymous]
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
        public async Task<IActionResult> Create(NewProductoVM producto)
        {
            if (!ModelState.IsValid)
            {
                var productoDropdownsData = await _service.GetNewProductoDropdownsValues();

                ViewBag.Caracteristicas = new SelectList(productoDropdownsData.Caracteristicas, "Id", "Nombre");
                ViewBag.Lineas = new SelectList(productoDropdownsData.Lineas, "Id", "Nombre");
                return View(producto);
            }
            await _service.AddNewProductoAsync(producto);
        return RedirectToAction(nameof(Index));
        }

        // GET: ProductosController/Edit/1
        public async Task<ActionResult> Edit(int id)
        {
            var productoDetalle = await _service.GetProductoByIdAsync(id);
            if(productoDetalle == null) return View("NotFound");

            var response = new NewProductoVM()
            {
                Id = productoDetalle.Id,  
                Codigo = productoDetalle.Codigo,
                Nombre = productoDetalle.Nombre,
                Descripcion1 = productoDetalle.Descripcion1,
                Contenido = productoDetalle.Contenido,
                Imagen1 = productoDetalle.Imagen1,
                Imagen2 = productoDetalle.Imagen2,
                Imagen3 = productoDetalle.Imagen3,
                Precio = productoDetalle.Precio,
                Descuento = productoDetalle.Descuento,
                Stock = productoDetalle.Stock,
                Valoracion = productoDetalle.Valoracion,
                CategoriaProducto = productoDetalle.CategoriaProducto,
                CaracteristicaId = productoDetalle.CaracteristicaId,
                LineaId = productoDetalle.LineaId
            };

            var productoDropdownsData = await _service.GetNewProductoDropdownsValues();
            ViewBag.Caracteristicas = new SelectList(productoDropdownsData.Caracteristicas, "Id", "Nombre");
            ViewBag.Lineas = new SelectList(productoDropdownsData.Lineas, "Id", "Nombre");
            return View(response);
        }

        // POST: ProductosController/Create
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewProductoVM producto)
        {
            if (id != producto.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var productoDropdownsData = await _service.GetNewProductoDropdownsValues();

                ViewBag.Caracteristicas = new SelectList(productoDropdownsData.Caracteristicas, "Id", "Nombre");
                ViewBag.Lineas = new SelectList(productoDropdownsData.Lineas, "Id", "Nombre");
                return View(producto);
            }
            await _service.UpdateProductoAsync(producto);
            return RedirectToAction(nameof(Index));
        }
    }
}
