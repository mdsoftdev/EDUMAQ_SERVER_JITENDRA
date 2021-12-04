using Edumaq.DataAccess.Models;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IItemService : IServiceBase<Item>
    {
        Task<Item> InsertItem(Item item);
        Task<Item> ModifyItem(long id, Item item);
    }
}
