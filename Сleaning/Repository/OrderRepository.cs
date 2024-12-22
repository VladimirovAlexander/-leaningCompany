using Microsoft.EntityFrameworkCore;
using Сleaning.Data;
using Сleaning.Interfaces;
using Сleaning.Models;

namespace Сleaning.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Order?> GetOrderAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                return order;
            }

            else return null;
            
        }

        public async Task<List<Order>?> GetAllOrdersAsync()
        {
            List<Order> orderList = await _context.Orders.ToListAsync();

            if(orderList != null)
            {
                return orderList;
            }

            else return null;
        }



    }
}
