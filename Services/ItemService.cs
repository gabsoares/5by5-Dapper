using Models;
using Repositories;

namespace Services
{
    public class ItemService
    {
        private IItemRepository _itemRepository;

        public ItemService()
        {
            _itemRepository = new ItemRepository();
        }

        public int Insert(Item item)
        {
            return _itemRepository.Insert(item);
        }
    }
}
