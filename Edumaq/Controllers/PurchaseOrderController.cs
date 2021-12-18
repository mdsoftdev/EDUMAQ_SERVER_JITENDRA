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
    public class PurchaseOrderController : Controller
    {
        private IPurchaseOrderService _service;
        public PurchaseOrderController(IPurchaseOrderService service)
        {
            _service = service;
        }
        [HttpGet("/api/purchaseOrders")]
        public IEnumerable<PurchaseOrder> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/purchaseOrders/quotandpo")]
        public int GetQuatAndPo()
        {
            var max = _service.GetQuotNoAndPo();
            return ++max;
        }

        [HttpGet("/api/purchaseOrders/noncomplete/{supplierId}")]
        public IEnumerable<PurchaseOrder> GetNonCopletePO(int supplierId)
        {
            return _service.GetNonCopletePO(supplierId);
        }

        [HttpGet("/api/purchaseOrders/{id}")]
        public async Task<PurchaseOrder> GetByID(long id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("/api/purchaseOrders")]
        public async Task<ActionResult<PurchaseOrderDto>> Create(PurchaseOrderDto itemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.PurchaseOrderNumber == itemDto.PurchaseOrderNumber))
                return StatusCode(409, $"PurchaseOrder already exists.");

            var res = await _service.InsertPurchaseOrder(itemDto.ConvertToModel(itemDto));

            return Ok(res);
        }

        [HttpPut("/api/purchaseOrders/{id}")]
        public async Task<ActionResult<PurchaseOrderDto>> Update(long id, PurchaseOrderDto itemDto)
        {
            if (id < 1)
                return StatusCode(409, $"Invalid Id.");

            await _service.ModifyPurchaseOrder(id, itemDto.ConvertToModel(itemDto));
            return Ok(itemDto);
        }

        [HttpDelete("/api/purchaseOrders/{id}")]
        public async Task<ActionResult<long>> Delete(long id)
        {
            await _service.Delete(id);
            return id;
        }
    }
}
