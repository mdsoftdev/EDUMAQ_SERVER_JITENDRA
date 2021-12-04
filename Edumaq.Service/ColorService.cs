using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;

namespace Edumaq.Service
{
    public class ColorService : ServiceBase<Color>, IColorService
    {
        private readonly IColorRepository _colorRepository;
        public ColorService(IColorRepository repository) : base(repository)
        {
            _colorRepository = repository;
        }
    }
}
