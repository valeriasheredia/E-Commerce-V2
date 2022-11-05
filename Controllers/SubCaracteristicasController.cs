using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class SubCaracteristicasController : Controller
    {
        private readonly ISubCaracteristicasService _service;
        public SubCaracteristicasController(ISubCaracteristicasService service)
        {
            _service = service; 
        }

        // GET: SubCaracteristicasController
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync(n =>n.Caracteristica);
            return View(data);
        }

        // GET: CaracteristicasController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var subCaracteristicaDetalle = await _service.GetByIdAsync(id);

            if (subCaracteristicaDetalle == null) return View("NotFound");
            return View(subCaracteristicaDetalle);
        }

        // GET: SubCaracteristicasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCaracteristicasController/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("CaracteristicaId, Nombre, Descripcion, Imagen")] SubCaracteristica subCaracteristica)
        {
            if (!ModelState.IsValid)
            {
                return View(subCaracteristica);
            }
            await _service.AddAsync(subCaracteristica);
            return RedirectToAction(nameof(Index));
        }

        // GET: SubCaracteristicasController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var subCaracteristicaEditar = await _service.GetByIdAsync(id);
            if (subCaracteristicaEditar == null) return View("NotFound");
            return View(subCaracteristicaEditar);
        }

        // POST: SubCaracteristicasController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, CaracteristicaId, Nombre, Descripcion, Imagen")] SubCaracteristica subCaracteristica)
        {
            if (!ModelState.IsValid)
            {
                return View(subCaracteristica);
            }
            await _service.UpdateAsync(id, subCaracteristica);
            return RedirectToAction(nameof(Index));
        }

        // GET: SubCaracteristicasController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var subCaracteristicaEliminar = await _service.GetByIdAsync(id);
            if (subCaracteristicaEliminar == null) return View("NotFound");
            return View(subCaracteristicaEliminar);
        }

        // POST: SubCaracteristicasController/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var subCaracteristicaEliminar = await _service.GetByIdAsync(id);
            if (subCaracteristicaEliminar == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
    
}
