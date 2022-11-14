using E_Commerce_V2.Data;
using E_Commerce_V2.Data.ViewModels;
using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager <ApplicationUser> _userManager;
        private readonly SignInManager <ApplicationUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Login() => View(new LoginVM());

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if(user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Productos");
                    }
                }
                TempData["Error"] = "Credenciales inválidas. Inténtelo nuevamente";
                return View(loginVM);
            }
            TempData["Error"] = "Credenciales inválidas. Inténtelo nuevamente";
            return View(loginVM);
        }

        public IActionResult Register() => View(new RegisterVM());
    }           
}
