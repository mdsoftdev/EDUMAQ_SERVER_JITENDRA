using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Edumaq.Service.Interface;
using Edumaq.Service;
using Edumaq.DataAccess.Models;
using Edumaq.Dto;
using Microsoft.AspNetCore.Cors;
using System.Net.Http;
using System.Net;

namespace Edumaq.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ItemGroupsController : ControllerBase
    {
        private IItemGroupService _service;
        public ItemGroupsController(IItemGroupService service) {
            _service = service;       
        }

        [HttpGet("/api/itemgroups")]
        public IEnumerable<ItemGroup> GetAllItemGroup()
        {
            //var rng = new Random();
            var test = _service.GetAll();
            return _service.GetAll();
        }

        [HttpGet("/api/itemgroups/{id}")]
        public async Task<ItemGroup> GetByItemGroupID(long id)
        {
            //var rng = new Random();
            return await _service.GetById(id);
        }

        //[HttpGet("/api/itemgroups/[action]")]
        //public ActionResult<bool> IsCurrentAcademicYearExits()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return _service.IsCurrentAcademicyearExists();
        //}


        [HttpPost("/api/itemgroups")]
        public async Task<ActionResult<ItemGroupDto>> CreateItemGroup(ItemGroupDto itemgroupDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.Name == itemgroupDto.Name))
                return StatusCode(409, $"Item Group already exists.");

            await _service.InsertItemGroup(itemgroupDto.ConvertToModel(itemgroupDto));

            return Ok(itemgroupDto);
        }

        [HttpPut("/api/itemgroups/{id}")]
        public ActionResult<ItemGroupDto> UpdateItemGroup(long id, ItemGroupDto itemgroupDto)
        {
            if (_service.IsExists(x => x.Name == itemgroupDto.Name))
                return StatusCode(409, $"Item Group already exists.");

            _service.ModifyItemGroup(id, itemgroupDto.ConvertToModel(itemgroupDto));
            return Ok(itemgroupDto);
        }

        [HttpDelete("/api/itemgroups/{id}")]
        public ActionResult<long> DeleteItemGroup(long id)
        {
            _service.Delete(id);
            //_logger.LogInformation("products", _products);
            return id;
        }

    }
}
