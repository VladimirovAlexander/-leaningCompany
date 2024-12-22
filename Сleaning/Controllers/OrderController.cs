using Microsoft.AspNetCore.Mvc;
using Сleaning.Dtos;
using Сleaning.Interfaces;

namespace Сleaning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController: Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            
            _orderRepository = orderRepository;
        
        }
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var order = await _orderRepository.GetAllOrdersAsync();

            var resultModel = new GetAllOrdersViewDto() { 
                OrdersList = order

            };

            return View(resultModel);
        }
    }
}
