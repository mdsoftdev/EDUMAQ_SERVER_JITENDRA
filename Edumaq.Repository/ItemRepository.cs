using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public ItemRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
