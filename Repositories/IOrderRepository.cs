using Models;

namespace Repositories
{
    public interface IOrderRepository
    {
        bool Insert(Order o);
    }
}
