using Models;
using Repositories;

namespace Services
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public bool Insert(Order o)
        {
            return _orderRepository.Insert(o);
        }
    }
}
