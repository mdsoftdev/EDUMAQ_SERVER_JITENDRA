using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class PurchaseOrderService : ServiceBase<PurchaseOrder>, IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        public PurchaseOrderService(IPurchaseOrderRepository repository) : base(repository)
        {
            _purchaseOrderRepository = repository;
        }

        public async Task<PurchaseOrder> InsertPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            return await _purchaseOrderRepository.Create(purchaseOrder);
        }

        public async Task<PurchaseOrder> ModifyPurchaseOrder(long id, PurchaseOrder purchaseOrder)
        {
            await _purchaseOrderRepository.Update(id, purchaseOrder);
            return purchaseOrder;
        }

        public int GetQuotNoAndPo()
        {
            var quotList = _purchaseOrderRepository.GetAll();

            if(quotList != null && quotList.Any())
            {
                return quotList.Max(a => a.QuotationNo);
            }
            else
            {
                return 0;
            }
        }
    }
}
