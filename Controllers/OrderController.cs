using Models;
using Services;

namespace Controllers
{
    public class OrderController
    {
        private OrderService _pedidoService;

        public OrderController()
        {
            _pedidoService = new OrderService();
        }

        public bool Insert(Order o)
        {
            return _pedidoService.Insert(o);
        }
    }
}