using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class ItemService : ServiceBase<Item>, IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository repository) : base(repository)
        {
            _itemRepository = repository;
        }

        public async Task<Item> InsertSupplier(Item item)
        {
            return await _itemRepository.Create(item);
        }

        public async Task<Item> ModifySupplier(long id, Item item)
        {
            await _itemRepository.Update(id, item);
            return item;
        }
    }
}
