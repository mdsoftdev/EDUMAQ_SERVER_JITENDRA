using Edumaq.DataAccess.Models;
using Edumaq.Dto;
using Edumaq.Service.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdumaqAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ItemsController : Controller
    {
        private IItemService _service;
        public ItemsController(IItemService service)
        {
            _service = service;
        }
        [HttpGet("/api/items")]
        public IEnumerable<Item> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/items/{id}")]
        public async Task<Item> GetByID(long id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("/api/items")]
        public async Task<ActionResult<ItemDto>> Create(ItemDto itemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.ItemName == itemDto.ItemName))
                return StatusCode(409, $"Item already exists.");

            await _service.InsertSupplier(itemDto.ConvertToModel(itemDto));

            return Ok(itemDto);
        }

        [HttpPut("/api/items/{id}")]
        public async Task<ActionResult<ItemDto>> Update(long id, ItemDto itemDto)
        {
            if (_service.IsExists(x => x.ItemName == itemDto.ItemName))
                return StatusCode(409, $"Supplier already exists.");

            await _service.ModifySupplier(id, itemDto.ConvertToModel(itemDto));
            return Ok(itemDto);
        }

        [HttpDelete("/api/items/{id}")]
        public async Task<ActionResult<long>> Delete(long id)
        {
            await _service.Delete(id);
            return id;
        }
    }
}
