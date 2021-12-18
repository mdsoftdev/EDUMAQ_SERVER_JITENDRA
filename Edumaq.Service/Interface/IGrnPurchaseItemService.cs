using Edumaq.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IGrnPurchaseItemService : IServiceBase<GrnPurchaseItem>
    {
        Task<GrnPurchaseItem> InsertGrnPurchaseItem(GrnPurchaseItem productBundle);
        Task<GrnPurchaseItem> ModifyGrnPurchaseItem(long id, GrnPurchaseItem productBundle);

        IEnumerable<GrnPurchaseItem> GetListById(long id);
    }
}
