using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class PurchaseOrderItemRepository : RepositoryBase<PurchaseOrderItem>, IPurchaseOrderItemRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public PurchaseOrderItemRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
