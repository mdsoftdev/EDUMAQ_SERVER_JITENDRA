using Edumaq.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IProductBundleService : IServiceBase<ProductBundle>
    {
        Task<ProductBundle> InsertProductBundle(ProductBundle productBundle);
        Task<ProductBundle> ModifyProductBundle(long id, ProductBundle productBundle);

        IEnumerable<ProductBundle> GetListById(long id);
    }
}
