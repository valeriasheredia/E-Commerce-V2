using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class SubLineasController : Controller
    {
        private readonly ISubLineasService _service;
        public SubLineasController(ISubLineasService service)
        {
            _service = service;
        }

        // GET: SubLineasController
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Linea);
            return View(data);
        }

        // GET: SubLineasController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var subLineaDetalle = await _service.GetByIdAsync(id);

            if (subLineaDetalle == null) return View("NotFound");
            return View(subLineaDetalle);
        }

        // GET: SubLineasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubLineasController/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nombre, Descripcion, Imagen")] SubLinea subLinea)
        {
            if (!ModelState.IsValid)
            {
                return View(subLinea);
            }
            await _service.AddAsync(subLinea);
            return RedirectToAction(nameof(Index));
        }

        // GET: SubLineasController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var subLineaEditar = await _service.GetByIdAsync(id);
            if (subLineaEditar == null) return View("NotFound");
            return View(subLineaEditar);
        }

        // POST: SubLineasController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, LineaId, Nombre, Descripcion, Imagen")] SubLinea subLinea)
        {
            if (!ModelState.IsValid)
            {
                return View(subLinea);
            }
            await _service.UpdateAsync(id, subLinea);
            return RedirectToAction(nameof(Index));
        }

        // GET: SubLineasController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var subLineaEliminar = await _service.GetByIdAsync(id);
            if (subLineaEliminar == null) return View("NotFound");
            return View(subLineaEliminar);
        }

        // POST: SubLineasController/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var subLineaEliminar = await _service.GetByIdAsync(id);
            if (subLineaEliminar == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
