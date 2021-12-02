using Edumaq.DataAccess.Models;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IItemService : IServiceBase<Item>
    {
        Task<Item> InsertSupplier(Item item);
        Task<Item> ModifySupplier(long id, Item item);
    }
}
