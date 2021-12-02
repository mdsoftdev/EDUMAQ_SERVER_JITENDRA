using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;

namespace Edumaq.Repository
{
    public class ColorRepository : RepositoryBase<Color>,  IColorRepository
    {
        private readonly EdumaqDBContext _dbContext;
        public ColorRepository(EdumaqDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
