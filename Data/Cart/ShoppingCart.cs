using E_Commerce_V2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Commerce_V2.Data.Carrito
{
    public class ShoppingCart
    {
        public AppDbContext _context { get; set; }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }
        
        public static ShoppingCart GetShoppingCart(IServiceProvider service)
        {
            ISession session =service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId")?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId};
        }

        public void AddItemToCart(Producto producto)
        {
            var shoppingCartItem = 
                _context.ShoppingCartItems
                .FirstOrDefault(n => n.Producto.Id == producto.Id 
                && n.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Producto = producto,
                    Amount = 1
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Producto producto)
        {
            var shoppingCartItem =
               _context.ShoppingCartItems
               .FirstOrDefault(n => n.Producto.Id == producto.Id
               && n.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem != null)
            {
              if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _context.SaveChanges();
        }


        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = 
                _context.ShoppingCartItems.
                Where(n => n.ShoppingCartId == ShoppingCartId)
                .Include(n => n.Producto).ToList());
        }

        public double GetShoppingCartTotal() => 
            (double)_context.ShoppingCartItems
            .Where(n => n.ShoppingCartId == ShoppingCartId)
            .Select(n => n.Producto.Precio * n.Amount).Sum();      
    }
}
