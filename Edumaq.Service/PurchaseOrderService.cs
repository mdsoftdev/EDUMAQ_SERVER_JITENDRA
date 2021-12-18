using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class PurchaseOrderService : ServiceBase<PurchaseOrder>, IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly IPurchaseOrderItemRepository _purchaseOrderItemRepository;
        private readonly IGrnPurchaseRepository _grnPurchaseRepository;
        private readonly IGrnPurchaseItemRepository _grnPurchaseItemRepository;
        public PurchaseOrderService(IPurchaseOrderRepository repository, IPurchaseOrderItemRepository itemRepository
            ,IGrnPurchaseRepository grnPurchaseRepository, IGrnPurchaseItemRepository grnPurchaseItemRepository) : base(repository)
        {
            _purchaseOrderRepository = repository;
            _purchaseOrderItemRepository = itemRepository;
            _grnPurchaseRepository = grnPurchaseRepository;
            _grnPurchaseItemRepository = grnPurchaseItemRepository;
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

        public IEnumerable<PurchaseOrder> GetNonCopletePO(int supplierId)
        {
            List<PurchaseOrder> poList;
            List<GrnPurchase> grnList;
            
            // if supplierId is available then get data based on supplierId
            if(supplierId > 0)
            {
                poList = _purchaseOrderRepository.GetAll().Where(po => po.SupplierId == supplierId).ToList();
                grnList = _grnPurchaseRepository.GetAll().Where(grn => grn.SupplierId == supplierId).ToList();
            }
            else
            {
                poList = _purchaseOrderRepository.GetAll().ToList();
                grnList = _grnPurchaseRepository.GetAll().ToList();
            }
            
            
            var poItemList = _purchaseOrderItemRepository.GetAll();
            var grnItemList = _grnPurchaseItemRepository.GetAll();

            // get items agains purchase order
            var poItems = from po in poList
                      join poItem in poItemList
                      on po.Id equals poItem.PurchaseOrderId
                     select new Tuple<int, long>( po.PurchaseOrderNumber, poItem.ItemId );
            
            // get items agains grn purchase
            var grnItems = from grn in grnList
                           join grnItem in grnItemList
                           on grn.Id equals grnItem.GrnPurchaseId
                           select new Tuple<int, long>(grn.PONumber, grnItem.ItemId);

            var matchedPOs = compareAndGetMatchedPo(poItems, grnItems);
            
            // exclude and returned matched (completed) purchase orders
            return from po in poList
                   where !matchedPOs.Any(x => x == po.PurchaseOrderNumber)
            select po;

        }

        private List<int> compareAndGetMatchedPo(IEnumerable<Tuple<int, long>> poItems, IEnumerable<Tuple<int, long>> grnItems)
        {
            List<int> poNumbers = new List<int>();
            var distinctPOs = poItems.GroupBy(p => p.Item1)
                           .Select(grp => grp.First())
                           .ToArray();

            foreach (var po in distinctPOs)
            {
                var pItems = poItems.Where(p => p.Item1 == po.Item1).Select( p2 => p2.Item2);
                var gItems = grnItems.Where(g => g.Item1 == po.Item1).Select(p2 => p2.Item2);
                var theyMatch = !pItems.Except(gItems).Any();
                if(theyMatch)
                {
                    poNumbers.Add(po.Item1);
                }
            }
            return poNumbers;   
        }
    }
}
