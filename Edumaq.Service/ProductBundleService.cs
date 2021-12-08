using Edumaq.DataAccess.Models;
using Edumaq.Repository.Interfaces;
using Edumaq.Service.Interface;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Edumaq.Service
{
    public class ProductBundleService : ServiceBase<ProductBundle>, IProductBundleService
    {
        private readonly IProductBundleRepository _productBundleRepository;
        public ProductBundleService(IProductBundleRepository repository) : base(repository)
        {
            _productBundleRepository = repository;
        }

        public async Task<ProductBundle> InsertProductBundle(ProductBundle productBundle)
        {
            return await _productBundleRepository.Create(productBundle);
        }

        public async Task<ProductBundle> ModifyProductBundle(long id, ProductBundle productBundle)
        {
            await _productBundleRepository.Update(id, productBundle);
            return productBundle;
        }

        public IEnumerable<ProductBundle> GetListById(long id)
        {
            return _productBundleRepository.GetAll().Where(b => b.BundleId == id).ToList();
        }
    }
}
