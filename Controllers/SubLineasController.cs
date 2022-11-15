using E_Commerce_V2.Data;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    [Authorize]
    public class SubLineasController : Controller
    {
        private readonly ISubLineasService _service;

        //Constructor
        public SubLineasController(ISubLineasService service)
        {
            _service = service;
        }

        // GET: SubLineasController
        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Linea);
            return View(data);
        }

        //GET: SubLinea/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var subLineaDetails = await _service.GetSubLineaByIdAsync(id);
            return View(subLineaDetails);
        }

        //GET: SubLineas/Create
        public async Task<IActionResult> Create()
        {
            var subLineaDropdownsData = await _service.GetNewSubLineaDropdownsValues();
            ViewBag.Lineas = new SelectList(subLineaDropdownsData.Lineas, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewSubLineaVM sublinea)
        {
            if (!ModelState.IsValid)
            {
                var subLineaDropdownsData = await _service.GetNewSubLineaDropdownsValues();

                ViewBag.Lineas = new SelectList(subLineaDropdownsData.Lineas, "Id", "Nombre");
                return View(sublinea);
            }
            await _service.AddNewSubLineaAsync(sublinea);
            return RedirectToAction(nameof(Index));
        }



        //GET: SubLineas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var subLineaDetails = await _service.GetSubLineaByIdAsync(id);
            if(subLineaDetails == null) return View("NotFound");

            var response = new NewSubLineaVM()
            {
                Id = subLineaDetails.Id,
                Nombre = subLineaDetails.Nombre,
                Descripcion = subLineaDetails.Descripcion,
                Imagen = subLineaDetails.Imagen,
                LineaId = subLineaDetails.LineaId
            };

            var subLineaDropdownsData = await _service.GetNewSubLineaDropdownsValues();
            ViewBag.Lineas = new SelectList(subLineaDropdownsData.Lineas, "Id", "Nombre");
            return View(response);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewSubLineaVM sublinea)
        {
            if (id != sublinea.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var subLineaDropdownsData = await _service.GetNewSubLineaDropdownsValues();

                ViewBag.Lineas = new SelectList(subLineaDropdownsData.Lineas, "Id", "Nombre");
                return View(sublinea);
            }
            await _service.UpdateSubLineaAsync(sublinea);
            return RedirectToAction(nameof(Index));
        }

        //public async Task<ActionResult> Details(int id)
        //{
        //    var subLineaDetalle = await _service.GetSubLineaIdAsync(id);

        //    //if (subLineaDetalle == null) return View("NotFound");
        //    return View(subLineaDetalle);
        //}

        //// GET: SubLineasController/Create
        //public async Task<ActionResult> Create()
        //{
        //    var LineaDropdownsData = await _service.GetNewLineaDropdownsValues();
        //    ViewBag.Linea = new SelectList(LineaDropdownsData.Lineas, "Id", "Nombre");
        //    return View();
        //}


        //// POST: SubLineasController/Create
        //[HttpPost]
        //public async Task<IActionResult> Create([Bind("Nombre, Descripcion, Imagen")] SubLinea subLinea)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(subLinea);
        //    }
        //    await _service.AddAsync(subLinea);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: SubLineasController/Edit/5
        //public async Task<ActionResult> Edit(int id)
        //{
        //    var subLineaEditar = await _service.GetByIdAsync(id);
        //    if (subLineaEditar == null) return View("NotFound");
        //    return View(subLineaEditar);
        //}

        //// POST: SubLineasController/Edit/5
        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, [Bind("Id, LineaId, Nombre, Descripcion, Imagen")] SubLinea subLinea)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(subLinea);
        //    }
        //    await _service.UpdateAsync(id, subLinea);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: SubLineasController/Delete/5
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var subLineaEliminar = await _service.GetByIdAsync(id);
        //    if (subLineaEliminar == null) return View("NotFound");
        //    return View(subLineaEliminar);
        //}

        //// POST: SubLineasController/Delete/5
        //[HttpPost, ActionName("Delete")]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    var subLineaEliminar = await _service.GetByIdAsync(id);
        //    if (subLineaEliminar == null) return View("NotFound");

        //    await _service.DeleteAsync(id);

        //    return RedirectToAction(nameof(Index));
        //}

        // GET: SubLineasController/Details/5
        //public async Task<ActionResult> Details(int id)
        //{
        //    var subLineaDetalle = await _service.GetByIdAsync(id);

        //    if (subLineaDetalle == null) return View("NotFound");
        //    return View(subLineaDetalle);
        //}
    }
}
