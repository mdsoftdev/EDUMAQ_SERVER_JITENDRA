using Edumaq.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IPurchaseOrderItemService : IServiceBase<PurchaseOrderItem>
    {
        Task<PurchaseOrderItem> InsertPurchaseOrderItem(PurchaseOrderItem productBundle);
        Task<PurchaseOrderItem> ModifyPurchaseOrderItem(long id, PurchaseOrderItem productBundle);

        IEnumerable<PurchaseOrderItem> GetListById(long id);
    }
}
