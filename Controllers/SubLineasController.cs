using E_Commerce_V2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class SubLineasController : Controller
    {
        private readonly AppDbContext _context;
        public SubLineasController(AppDbContext context)
        {
            _context = context;
        }
        // GET: SubLineasController
        public async Task<ActionResult> Index()
        {
            var data = await _context.SubLineas.ToListAsync();
            return View(data);
        }

        // GET: SubLineasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubLineasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubLineasController/Create
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

        // GET: SubLineasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubLineasController/Edit/5
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

        // GET: SubLineasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubLineasController/Delete/5
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
