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
    public class GrnPurchaseController : Controller
    {
        private IGrnPurchaseService _service;
        public GrnPurchaseController(IGrnPurchaseService service)
        {
            _service = service;
        }
        [HttpGet("/api/grnPurchases")]
        public IEnumerable<GrnPurchase> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/grnPurchases/grnno")]
        public int GetQuatAndPo()
        {
            var max = _service.GetGrnNo();
            return ++max;
        }

        [HttpGet("/api/grnPurchases/{id}")]
        public async Task<GrnPurchase> GetByID(long id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("/api/grnPurchases")]
        public async Task<ActionResult<GrnPurchaseDto>> Create(GrnPurchaseDto itemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.GRNNumber == itemDto.GRNNumber))
                return StatusCode(409, $"GrnPurchase already exists.");

            var res = await _service.InsertGrnPurchase(itemDto.ConvertToModel(itemDto));

            return Ok(res);
        }

        [HttpPut("/api/grnPurchases/{id}")]
        public async Task<ActionResult<GrnPurchaseDto>> Update(long id, GrnPurchaseDto itemDto)
        {
            if (id < 1)
                return StatusCode(409, $"Invalid Id.");

            await _service.ModifyGrnPurchase(id, itemDto.ConvertToModel(itemDto));
            return Ok(itemDto);
        }

        [HttpDelete("/api/grnPurchases/{id}")]
        public async Task<ActionResult<long>> Delete(long id)
        {
            await _service.Delete(id);
            return id;
        }
    }
}
