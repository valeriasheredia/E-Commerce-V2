﻿using E_Commerce_V2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public class OrdersService : IOrdersService
    {

        private readonly AppDbContext _context;
        public OrdersService(AppDbContext context)
        {
            _context = context;   
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await _context.Orders
                .Include(n => n.OrderItems)
                .ThenInclude(n => n.Producto)
                .Where (n => n.UserId == userId)
                .ToListAsync();

            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach(var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    ProductoId = item.Producto.Id,
                    OrderId = order.Id,
                    Price = (double)item.Producto.Precio
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }
    }
}
