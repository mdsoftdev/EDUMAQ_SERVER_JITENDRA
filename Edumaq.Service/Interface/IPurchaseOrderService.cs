﻿using Edumaq.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IPurchaseOrderService : IServiceBase<PurchaseOrder>
    {
        Task<PurchaseOrder> InsertPurchaseOrder(PurchaseOrder item);
        Task<PurchaseOrder> ModifyPurchaseOrder(long id, PurchaseOrder item);

        int GetQuotNoAndPo();
        IEnumerable<PurchaseOrder> GetNonCopletePO(int supplierId);
    }
}
