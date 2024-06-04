using Models;
using Repositories;

namespace Services
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;
        private IItemRepository _itemRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _itemRepository = new ItemRepository();
        }

        public bool Insert(Order order)
        {
            int idItem = _itemRepository.Insert(order.Item);
            order.Item.Id = idItem;
            return _orderRepository.Insert(order);
        }
    }
}
