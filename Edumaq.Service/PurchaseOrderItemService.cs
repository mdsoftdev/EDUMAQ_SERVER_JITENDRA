using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class PurchaseOrderItemService : ServiceBase<PurchaseOrderItem>, IPurchaseOrderItemService
    {
        private readonly IPurchaseOrderItemRepository _purchaseOrderItemRepository;
        public PurchaseOrderItemService(IPurchaseOrderItemRepository repository) : base(repository)
        {
            _purchaseOrderItemRepository = repository;
        }

        public async Task<PurchaseOrderItem> InsertPurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            return await _purchaseOrderItemRepository.Create(purchaseOrderItem);
        }

        public async Task<PurchaseOrderItem> ModifyPurchaseOrderItem(long id, PurchaseOrderItem purchaseOrderItem)
        {
            await _purchaseOrderItemRepository.Update(id, purchaseOrderItem);
            return purchaseOrderItem;
        }

        public IEnumerable<PurchaseOrderItem> GetListById(long id)
        {
            return _purchaseOrderItemRepository.GetAll().Where(b => b.PurchaseOrderId == id).ToList();
        }
    }
}
