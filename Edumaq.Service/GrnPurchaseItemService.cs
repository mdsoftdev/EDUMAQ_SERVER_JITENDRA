using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class GrnPurchaseItemService : ServiceBase<GrnPurchaseItem>, IGrnPurchaseItemService
    {
        private readonly IGrnPurchaseItemRepository _grnPurchaseItemRepository;
        public GrnPurchaseItemService(IGrnPurchaseItemRepository repository) : base(repository)
        {
            _grnPurchaseItemRepository = repository;
        }

        public async Task<GrnPurchaseItem> InsertGrnPurchaseItem(GrnPurchaseItem grnPurchaseItem)
        {
            return await _grnPurchaseItemRepository.Create(grnPurchaseItem);
        }

        public async Task<GrnPurchaseItem> ModifyGrnPurchaseItem(long id, GrnPurchaseItem grnPurchaseItem)
        {
            await _grnPurchaseItemRepository.Update(id, grnPurchaseItem);
            return grnPurchaseItem;
        }

        public IEnumerable<GrnPurchaseItem> GetListById(long id)
        {
            return _grnPurchaseItemRepository.GetAll().Where(b => b.GrnPurchaseId == id).ToList();
        }
    }
}
