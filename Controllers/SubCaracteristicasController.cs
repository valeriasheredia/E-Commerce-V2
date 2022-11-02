using E_Commerce_V2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class SubCaracteristicasController : Controller
    {
        private readonly AppDbContext _context;
        public SubCaracteristicasController(AppDbContext context)
        {
            _context = context;
        }
        // GET: SubCaracteristicasController
        public async Task<ActionResult> Index()
        {
            var data = await _context.SubCaracteristicas.Include(n=>n.Caracteristica).ToListAsync();
            return View(data);
        }

        // GET: SubCaracteristicasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubCaracteristicasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCaracteristicasController/Create
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

        // GET: SubCaracteristicasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubCaracteristicasController/Edit/5
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

        // GET: SubCaracteristicasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubCaracteristicasController/Delete/5
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
