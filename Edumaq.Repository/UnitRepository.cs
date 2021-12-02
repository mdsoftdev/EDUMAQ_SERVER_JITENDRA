using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class UnitRepository : RepositoryBase<Unit>, IUnitRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public UnitRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
