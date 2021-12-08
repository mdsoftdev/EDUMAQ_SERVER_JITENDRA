using Microsoft.AspNetCore.Mvc;
using Edumaq.DataAccess.Models;
using Edumaq.Dto;
using Edumaq.Service.Interface;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdumaqAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ProductBundlesController : Controller
    {
        private IProductBundleService _service;
        public ProductBundlesController(IProductBundleService service)
        {
            _service = service;
        }
        [HttpGet("/api/productbundles")]
        public IEnumerable<ProductBundle> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/productbundles/{id}")]
        public IEnumerable<ProductBundle> GetByID(long id)
        {
            return _service.GetListById(id);
        }

        [HttpPost("/api/productbundles/single")]
        public async Task<ActionResult<ProductBundleDto>> Create(ProductBundleDto productBundleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.BundleId == productBundleDto.BundleId && x.ItemId == productBundleDto.ItemId))
                return StatusCode(409, $"Product Bundle already exists.");

            await _service.InsertProductBundle(productBundleDto.ConvertToModel(productBundleDto));

            return Ok(productBundleDto);
        }

        [HttpPost("/api/productbundles/bulk")]
        public async Task<ActionResult<ProductBundleDto>> CreateUpdateBulk([FromBody] List<ProductBundleDto> productBundleDtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foreach(var productBundleDto in productBundleDtos)
            {
                if (productBundleDto.Id < 1)
                {
                    await _service.InsertProductBundle(productBundleDto.ConvertToModel(productBundleDto));
                }
                else
                {
                    await _service.ModifyProductBundle(productBundleDto.Id, productBundleDto.ConvertToModel(productBundleDto));
                }

            }

            

            return Ok();
        }

        [HttpPut("/api/productbundles/single/{id}")]
        public async Task<ActionResult<ProductBundleDto>> Update(long id, ProductBundleDto productBundleDto)
        {
            if (id < 1)
                return StatusCode(409, $"Invalid Id.");

            await _service.ModifyProductBundle(id, productBundleDto.ConvertToModel(productBundleDto));
            return Ok(productBundleDto);
        }

        [HttpDelete("/api/productbundles/single/{id}")]
        public async Task<ActionResult<long>> Delete(long id)
        {
            await _service.Delete(id);
            return id;
        }
    }
}
