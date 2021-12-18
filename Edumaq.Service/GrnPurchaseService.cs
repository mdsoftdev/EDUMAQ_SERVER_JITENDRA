using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace Edumaq.Service
{
    public class GrnPurchaseService : ServiceBase<GrnPurchase>, IGrnPurchaseService
    {
        private readonly IGrnPurchaseRepository _grnPurchaseRepository;
        public GrnPurchaseService(IGrnPurchaseRepository repository) : base(repository)
        {
            _grnPurchaseRepository = repository;
        }

        public async Task<GrnPurchase> InsertGrnPurchase(GrnPurchase grnPurchase)
        {
            return await _grnPurchaseRepository.Create(grnPurchase);
        }

        public async Task<GrnPurchase> ModifyGrnPurchase(long id, GrnPurchase grnPurchase)
        {
            await _grnPurchaseRepository.Update(id, grnPurchase);
            return grnPurchase;
        }

        public int GetGrnNo()
        {
            var quotList = _grnPurchaseRepository.GetAll();

            if(quotList != null && quotList.Any())
            {
                return quotList.Max(a => a.GRNNumber);
            }
            else
            {
                return 100000;
            }
        }
    }
}
