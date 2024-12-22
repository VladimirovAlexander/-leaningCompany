using Сleaning.Models;

namespace Сleaning.Interfaces
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderAsync(int id);

        public Task<List<Order>> GetAllOrdersAsync();
    }
}
