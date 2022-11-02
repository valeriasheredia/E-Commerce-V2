using E_Commerce_V2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class LineasController : Controller
    {
        private readonly AppDbContext _context;
        public LineasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: LineasController
        public async Task<ActionResult> Index()
        {
            var data = await _context.Lineas.ToListAsync();
            return View(data);
        }

        // GET: LineasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineasController/Create
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

        // GET: LineasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LineasController/Edit/5
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

        // GET: LineasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LineasController/Delete/5
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
