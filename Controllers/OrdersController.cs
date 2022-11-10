using E_Commerce_V2.Data.Carrito;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_V2.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProductosService _productosService;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IProductosService productosService, ShoppingCart shoppingCart)
        {
            _productosService = productosService; 
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                shoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
    }
}
