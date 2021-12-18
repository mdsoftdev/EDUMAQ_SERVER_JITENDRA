using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class GrnPurchaseItemRepository : RepositoryBase<GrnPurchaseItem>, IGrnPurchaseItemRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public GrnPurchaseItemRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
