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
    public class GrnPurchaseItemsController : Controller
    {
        private IGrnPurchaseItemService _service;
        public GrnPurchaseItemsController(IGrnPurchaseItemService service)
        {
            _service = service;
        }
        [HttpGet("/api/grnPurchaseItems")]
        public IEnumerable<GrnPurchaseItem> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/grnPurchaseItems/{id}")]
        public IEnumerable<GrnPurchaseItem> GetByID(long id)
        {
            return _service.GetListById(id);
        }

        [HttpPost("/api/grnPurchaseItems/single")]
        public async Task<ActionResult<GrnPurchaseItemDto>> Create(GrnPurchaseItemDto grnPurchaseItemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.Id == grnPurchaseItemDto.Id))
                return StatusCode(409, $"grnPurchase Item already exists.");

            await _service.InsertGrnPurchaseItem(grnPurchaseItemDto.ConvertToModel(grnPurchaseItemDto));

            return Ok(grnPurchaseItemDto);
        }

        [HttpPost("/api/grnPurchaseItems/bulk/{id}")]
        public async Task<ActionResult<GrnPurchaseItemDto>> CreateUpdateBulk(long id, [FromBody] List<GrnPurchaseItemDto> grnPurchaseItemDtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // get the difference between incoming list and the existing items items and delete them
            var existingitem = _service.GetListById(id);
            var itemDiff = existingitem.Where(item => !grnPurchaseItemDtos.Any(e => item.Id == e.Id));
            foreach (var deleteitemItem in itemDiff)
            {
                await Delete(deleteitemItem.Id);
            }

            // insert update item items based on the id
            foreach (var grnPurchaseItemDto in grnPurchaseItemDtos)
            {
                await _service.InsertGrnPurchaseItem(grnPurchaseItemDto.ConvertToModel(grnPurchaseItemDto));

                //if (grnPurchaseItemDto.Id < 1)
                //{
                //    await _service.InsertGrnPurchaseItem(grnPurchaseItemDto.ConvertToModel(grnPurchaseItemDto));
                //}
                //else
                //{
                //    await _service.ModifyGrnPurchaseItem(grnPurchaseItemDto.Id, grnPurchaseItemDto.ConvertToModel(grnPurchaseItemDto));
                //}

            }

            return Ok();
        }

        [HttpPut("/api/grnPurchaseItems/single/{id}")]
        public async Task<ActionResult<GrnPurchaseItemDto>> Update(long id, GrnPurchaseItemDto grnPurchaseItemDto)
        {
            if (id < 1)
                return StatusCode(409, $"Invalid Id.");

            await _service.ModifyGrnPurchaseItem(id, grnPurchaseItemDto.ConvertToModel(grnPurchaseItemDto));
            return Ok(grnPurchaseItemDto);
        }

        [HttpDelete("/api/grnPurchaseItems/single/{id}")]
        public async Task<ActionResult<long>> Delete(long id)
        {
            await _service.Delete(id);
            return id;
        }
    }
}
