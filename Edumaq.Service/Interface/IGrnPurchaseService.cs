using Edumaq.DataAccess.Models;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IGrnPurchaseService : IServiceBase<GrnPurchase>
    {
        Task<GrnPurchase> InsertGrnPurchase(GrnPurchase item);
        Task<GrnPurchase> ModifyGrnPurchase(long id, GrnPurchase item);

        int GetGrnNo();
    }
}
