using Microsoft.AspNetCore.Mvc;
using Edumaq.DataAccess.Models;
using Edumaq.Dto;
using Edumaq.Service.Interface;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace EdumaqAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class PurchaseOrderItemsController : Controller
    {
        private IPurchaseOrderItemService _service;
        public PurchaseOrderItemsController(IPurchaseOrderItemService service)
        {
            _service = service;
        }
        [HttpGet("/api/purchaseOrderItems")]
        public IEnumerable<PurchaseOrderItem> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/purchaseOrderItems/{id}")]
        public IEnumerable<PurchaseOrderItem> GetByID(long id)
        {
            return _service.GetListById(id);
        }

        [HttpPost("/api/purchaseOrderItems/single")]
        public async Task<ActionResult<PurchaseOrderItemDto>> Create(PurchaseOrderItemDto purchaseOrderItemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.Id == purchaseOrderItemDto.Id))
                return StatusCode(409, $"purchaseOrder Item already exists.");

            await _service.InsertPurchaseOrderItem(purchaseOrderItemDto.ConvertToModel(purchaseOrderItemDto));

            return Ok(purchaseOrderItemDto);
        }

        [HttpPost("/api/purchaseOrderItems/bulk/{id}")]
        public async Task<ActionResult<PurchaseOrderItemDto>> CreateUpdateBulk(long id, [FromBody] List<PurchaseOrderItemDto> purchaseOrderItemDtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // get the difference between incoming list and the existing items items and delete them
            var existingitem = _service.GetListById(id);
            var itemDiff = existingitem.Where(item => !purchaseOrderItemDtos.Any(e => item.Id == e.Id));
            foreach (var deleteitemItem in itemDiff)
            {
                await Delete(deleteitemItem.Id);
            }

            // insert update item items based on the id
            foreach (var purchaseOrderItemDto in purchaseOrderItemDtos)
            {
                if (purchaseOrderItemDto.Id < 1)
                {
                    await _service.InsertPurchaseOrderItem(purchaseOrderItemDto.ConvertToModel(purchaseOrderItemDto));
                }
                else
                {
                    await _service.ModifyPurchaseOrderItem(purchaseOrderItemDto.Id, purchaseOrderItemDto.ConvertToModel(purchaseOrderItemDto));
                }

            }

            return Ok();
        }

        [HttpPut("/api/purchaseOrderItems/single/{id}")]
        public async Task<ActionResult<PurchaseOrderItemDto>> Update(long id, PurchaseOrderItemDto purchaseOrderItemDto)
        {
            if (id < 1)
                return StatusCode(409, $"Invalid Id.");

            await _service.ModifyPurchaseOrderItem(id, purchaseOrderItemDto.ConvertToModel(purchaseOrderItemDto));
            return Ok(purchaseOrderItemDto);
        }

        [HttpDelete("/api/purchaseOrderItems/single/{id}")]
        public async Task<ActionResult<long>> Delete(long id)
        {
            await _service.Delete(id);
            return id;
        }
    }
}
