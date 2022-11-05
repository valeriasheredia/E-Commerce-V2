using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class CaracteristicasController : Controller
    {
        private readonly ICaracteristicasSservice _service;
        public CaracteristicasController(ICaracteristicasSservice service)
        {
            _service = service;
        }

        // GET: CaracteristicasController
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: CaracteristicasController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var caracteristicaDetalle=await _service.GetByIdAsync(id);

            if (caracteristicaDetalle == null) return View("NotFound");
            return View(caracteristicaDetalle);
        }

        // GET: CaracteristicasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaracteristicasController/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nombre, Descripcion, Imagen")] Caracteristica caracteristica)
        {
            if (!ModelState.IsValid)
            {
                return View(caracteristica);
            }
            await _service.AddAsync(caracteristica);
            return RedirectToAction(nameof(Index));
        }


        // GET: CaracteristicasController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var caracteristicaEditar = await _service.GetByIdAsync(id);
            if (caracteristicaEditar == null) return View("NotFound");
            return View(caracteristicaEditar);
        }

        // POST: LineasController/Edit/5

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Nombre, Descripcion, Imagen")] Caracteristica caracteristica)
        {
            if (!ModelState.IsValid)
            {
                return View(caracteristica);
            }
            await _service.UpdateAsync(id, caracteristica);
            return RedirectToAction(nameof(Index));
        }

        // GET: LineasController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var caracteristicaEliminar = await _service.GetByIdAsync(id);
            if (caracteristicaEliminar == null) return View("NotFound");
            return View(caracteristicaEliminar);
        }

        // POST: LineasController/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var caracteristicaEliminar = await _service.GetByIdAsync(id);
            if (caracteristicaEliminar == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
