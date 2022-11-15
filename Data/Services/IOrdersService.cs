using E_Commerce_V2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_V2.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync (string userId, string userRole);
        
    }
}
