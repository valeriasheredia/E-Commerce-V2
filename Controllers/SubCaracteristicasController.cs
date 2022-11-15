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
    public class SubCaracteristicasController : Controller
    {
        private readonly ISubCaracteristicasService _service;
        public SubCaracteristicasController(ISubCaracteristicasService service)
        {
            _service = service; 
        }
        //// GET: SubCaracteristicasController
        //public async Task<ActionResult> Index()
        //{
        //    var data = await _service.GetAllAsync(n =>n.Caracteristica);
        //    return View(data);
        //}

        //// GET: CaracteristicasController/Details/5
        //public async Task<ActionResult> Details(int id)
        //{
        //    var subCaracteristicaDetalle = await _service.GetByIdAsync(id);

        //    if (subCaracteristicaDetalle == null) return View("NotFound");
        //    return View(subCaracteristicaDetalle);
        //}

        //// GET: SubCaracteristicasController/Create

        //public async Task<ActionResult> Create()
        //{
        //    var CaracteristicaDropdownsData = await _service.GetNewCaracteristicaDropdownsValues();
        //    ViewBag.Caracteristicas = new SelectList(CaracteristicaDropdownsData.Caracteristicas, "Id", "Nombre");
        //    return View();
        //}

        //// POST: SubCaracteristicasController/Create
        //[HttpPost]
        //public async Task<IActionResult> Create([Bind("CaracteristicaId, Nombre, Descripcion, Imagen")] SubCaracteristica subCaracteristica)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(subCaracteristica);
        //    }
        //    await _service.AddAsync(subCaracteristica);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: SubCaracteristicasController/Edit/5
        //public async Task<ActionResult> Edit(int id)
        //{
        //    var subCaracteristicaEditar = await _service.GetByIdAsync(id);
        //    if (subCaracteristicaEditar == null) return View("NotFound");
        //    return View(subCaracteristicaEditar);
        //}

        //// POST: SubCaracteristicasController/Edit/5
        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, [Bind("Id, CaracteristicaId, Nombre, Descripcion, Imagen")] SubCaracteristica subCaracteristica)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(subCaracteristica);
        //    }
        //    await _service.UpdateAsync(id, subCaracteristica);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: SubCaracteristicasController/Delete/5
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var subCaracteristicaEliminar = await _service.GetByIdAsync(id);
        //    if (subCaracteristicaEliminar == null) return View("NotFound");
        //    return View(subCaracteristicaEliminar);
        //}

        //// POST: SubCaracteristicasController/Delete/5
        //[HttpPost, ActionName("Delete")]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    var subCaracteristicaEliminar = await _service.GetByIdAsync(id);
        //    if (subCaracteristicaEliminar == null) return View("NotFound");

        //    await _service.DeleteAsync(id);

        //    return RedirectToAction(nameof(Index));
        //}



        // GET: subCaracteristicasController

        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Caracteristica);
            return View(data);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var subCaracteristicaDetails = await _service.GetSubCaracteristicaByIdAsync(id);
            return View(subCaracteristicaDetails);
        }

        //GET: SubCaracteristicas/Create
        public async Task<IActionResult> Create()
        {
            var subCaracteristicaDropdownsData = await _service.GetNewSubCaracteristicaDropdownsValues();
            ViewBag.Caracteristicas = new SelectList(subCaracteristicaDropdownsData.Caracteristicas, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewSubCaracteristicaVM subcaracteristica)
        {
            if (!ModelState.IsValid)
            {
                var subCaracteristicaDropdownsData = await _service.GetNewSubCaracteristicaDropdownsValues();
                
                ViewBag.Caracteristicas = new SelectList(subCaracteristicaDropdownsData.Caracteristicas, "Id", "Nombre");
                return View(subcaracteristica);
            }
            await _service.AddNewSubCaracteristicaAsync(subcaracteristica);
            return RedirectToAction(nameof(Index));
        }


        //GET: subCaracteristicas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var subCaracteristicaDetails = await _service.GetSubCaracteristicaByIdAsync(id);
            if (subCaracteristicaDetails == null) return View("NotFound");

            var response = new NewSubCaracteristicaVM()
            {
                Id = subCaracteristicaDetails.Id,
                Nombre = subCaracteristicaDetails.Nombre,
                Descripcion = subCaracteristicaDetails.Descripcion,
                Imagen = subCaracteristicaDetails.Imagen,
                CaracteristicaId = subCaracteristicaDetails.CaracteristicaId
            };

            var subCaracteristicaDropdownsData = await _service.GetNewSubCaracteristicaDropdownsValues();
            ViewBag.Caracteristicas = new SelectList(subCaracteristicaDropdownsData.Caracteristicas, "Id", "Nombre");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewSubCaracteristicaVM subCaracteristica)
        {
            if (id != subCaracteristica.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var subCaracteristicaDropdownsData = await _service.GetNewSubCaracteristicaDropdownsValues();

                ViewBag.Caracteristicas = new SelectList(subCaracteristicaDropdownsData.Caracteristicas, "Id", "Nombre");
                return View(subCaracteristica);
            }
            await _service.UpdateSubCaracteristicasAsync(subCaracteristica);
            return RedirectToAction(nameof(Index));
        }
    }
    
}
