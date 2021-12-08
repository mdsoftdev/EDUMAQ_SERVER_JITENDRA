using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class ProductBundleRepository : RepositoryBase<ProductBundle>, IProductBundleRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public ProductBundleRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
