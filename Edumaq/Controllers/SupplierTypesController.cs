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
    public class SupplierTypesController : ControllerBase
    {
        private ISupplierTypeService _service;
        public SupplierTypesController(ISupplierTypeService service) {
            _service = service;       
        }

        [HttpGet("/api/suppliertypes")]
        public IEnumerable<SupplierType> GetAlSupplierType()
        {
            //var rng = new Random();
            var test = _service.GetAll();
            return _service.GetAll();
        }

        [HttpGet("/api/suppliertypes/{id}")]
        public async Task<SupplierType> GetBySupplierTypeID(long id)
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


        [HttpPost("/api/suppliertypes")]
        public async Task<ActionResult<SupplierTypeDto>> CreateSupplierType(SupplierTypeDto supplierTypeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.Name == supplierTypeDto.Name))
                return StatusCode(409, $"Supplier Type already exists.");

            await _service.InsertSupplierType(supplierTypeDto.ConvertToModel(supplierTypeDto));

            return Ok(supplierTypeDto);
        }

        [HttpPut("/api/suppliertypes/{id}")]
        public async Task<ActionResult<SupplierTypeDto>>  UpdateSupplierType(long id, SupplierTypeDto supplierTypeDto)
        {
            if (_service.IsExists(x => x.Name == supplierTypeDto.Name))
                return StatusCode(409, $"Supplier Type already exists.");

            await _service.ModifySupplierType(id, supplierTypeDto.ConvertToModel(supplierTypeDto));
            return Ok(supplierTypeDto);
        }

        [HttpDelete("/api/suppliertypes/{id}")]
        public async Task<ActionResult<long>> DeleteSupplierType(long id)
        {
            await _service.Delete(id);
            //_logger.LogInformation("products", _products);
            return id;
        }

    }
}
