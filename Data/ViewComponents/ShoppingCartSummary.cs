using E_Commerce_V2.Data.Carrito;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_V2.Data.ViewComponents
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items.Count);
        }
            
    }
}
