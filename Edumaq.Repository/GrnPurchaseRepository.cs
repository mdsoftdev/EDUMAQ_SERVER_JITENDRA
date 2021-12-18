using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class GrnPurchaseRepository : RepositoryBase<GrnPurchase>, IGrnPurchaseRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public GrnPurchaseRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
