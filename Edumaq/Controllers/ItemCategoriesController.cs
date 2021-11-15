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
    public class ItemCategoriesController : ControllerBase
    {
        private IItemCategoryService _service;
        public ItemCategoriesController(IItemCategoryService service) {
            _service = service;       
        }

        [HttpGet("/api/itemcategories")]
        public IEnumerable<ItemCategory> GetAllItemCategories()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/itemcategories/{id}")]
        public async Task<ItemCategory> GetByItemCategoryID(long id)
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


        [HttpPost("/api/itemcategories")]
        public async Task<ActionResult<ItemCategoryDto>> CreateItemCategory(ItemCategoryDto itemCategoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.Name == itemCategoryDto.Name))
                return StatusCode(409, $"Item Category already exists.");

            await _service.InsertItemCategory(itemCategoryDto.ConvertToModel(itemCategoryDto));

            return Ok(itemCategoryDto);
        }

        [HttpPut("/api/itemcategories/{id}")]
        public async Task<ActionResult<ItemCategoryDto>>  UpdateItemCategory(long id, ItemCategoryDto itemCategoryDto)
        {
            if (_service.IsExists(x => x.Name == itemCategoryDto.Name))
                return StatusCode(409, $"Item Category already exists.");
            await _service.ModifyItemCategory(id, itemCategoryDto.ConvertToModel(itemCategoryDto));
            return Ok(itemCategoryDto);
        }

        [HttpDelete("/api/itemcategories/{id}")]
        public ActionResult<long> DeleteItemCategory(long id)
        {
            _service.Delete(id);
            //_logger.LogInformation("products", _products);
            return id;
        }

    }
}
