using E_Commerce_V2.Data.Carrito;
using E_Commerce_V2.Data.Services;
using E_Commerce_V2.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Commerce_V2.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProductosService _productosService;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IProductosService productosService,
            ShoppingCart shoppingCart)
        {
            _productosService = productosService; 
            _shoppingCart = shoppingCart;
        }

      
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }


        public async Task<RedirectToActionResult> AddToShoppingCart(int id)
        {
            var item = await _productosService.GetProductoByIdAsync(id);
            if(item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
