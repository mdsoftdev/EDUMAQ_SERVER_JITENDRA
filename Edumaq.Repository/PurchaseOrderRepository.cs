using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class PurchaseOrderRepository : RepositoryBase<PurchaseOrder>, IPurchaseOrderRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public PurchaseOrderRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
