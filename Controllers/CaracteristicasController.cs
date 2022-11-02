using E_Commerce_V2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class CaracteristicasController : Controller
    {
        private readonly AppDbContext _context;
        public CaracteristicasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CaracteristicasController
        public async Task<ActionResult> Index()
        {
            var data = await _context.Caracteristicas.ToListAsync();
            return View(data);
        }

        // GET: CaracteristicasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CaracteristicasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaracteristicasController/Create
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

        // GET: CaracteristicasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CaracteristicasController/Edit/5
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

        // GET: CaracteristicasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CaracteristicasController/Delete/5
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
