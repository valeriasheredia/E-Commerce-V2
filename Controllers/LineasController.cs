using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Data.Static;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class LineasController : Controller
    {
        private readonly ILineasService _service;
        public LineasController(ILineasService service)
        {
            _service = service;
        }

        // GET: LineasController
        [AllowAnonymous]
        public async Task< ActionResult> Index()
        {
            var data =await _service.GetAllAsync();
            return View(data);
        }

        // GET: LineasController/Details/5
        [AllowAnonymous]
        public async Task<ActionResult> Details(int id)
        {
            var lineaDetalle=await _service.GetByIdAsync(id);

            if(lineaDetalle==null) return View("NotFound");
            return View(lineaDetalle);
        }

        // GET: LineasController/Create
      
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineasController/Create
        [HttpPost]
       public async Task<IActionResult> Create([Bind("Nombre, Descripcion, Imagen")]Linea linea)
        {
            if (!ModelState.IsValid)
            {
                return View(linea);
            }
           await _service.AddAsync(linea);
            return RedirectToAction(nameof(Index));
        }

        // GET: LineasController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var lineaEditar=await _service.GetByIdAsync(id);
            if(lineaEditar==null) return View("NotFound");
            return View(lineaEditar);
        }

        // POST: LineasController/Edit/5
      
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id, Nombre, Descripcion, Imagen")] Linea linea)
        {
            if (!ModelState.IsValid)
            {
                return View(linea);
            }
            await _service.UpdateAsync(id, linea);
            return RedirectToAction(nameof(Index));
        }

        // GET: LineasController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var lineaEliminar = await _service.GetByIdAsync(id);
            if (lineaEliminar == null) return View("NotFound");
            return View(lineaEliminar);
        }

        // POST: LineasController/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var lineaEliminar = await _service.GetByIdAsync(id);
            if (lineaEliminar == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
 