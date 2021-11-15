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
    public class SuppliersController : ControllerBase
    {
        private ISupplierService _service;
        public SuppliersController(ISupplierService service) {
            _service = service;       
        }

        [HttpGet("/api/suppliers")]
        public IEnumerable<Supplier> GetAllSupplier()
        {
            //var rng = new Random();
            var test = _service.GetAll();
            return _service.GetAll();
        }

        [HttpGet("/api/suppliers/{id}")]
        public async Task<Supplier> GetBySupplierID(long id)
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


        [HttpPost("/api/suppliers")]
        public async Task<ActionResult<SupplierDto>> CreateTax(SupplierDto supplierDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.SupplierName == supplierDto.SupplierName))
                return StatusCode(409, $"Supplier already exists.");

            await _service.InsertSupplier(supplierDto.ConvertToModel(supplierDto));

            return Ok(supplierDto);
        }

        [HttpPut("/api/suppliers/{id}")]
        public async Task<ActionResult<SupplierDto>>  UpdateSupplier(long id, SupplierDto supplierDto)
        {
            if (_service.IsExists(x => x.SupplierName == supplierDto.SupplierName))
                return StatusCode(409, $"Supplier already exists.");

            await _service.ModifySupplier(id, supplierDto.ConvertToModel(supplierDto));
            return Ok(supplierDto);
        }

        [HttpDelete("/api/suppliers/{id}")]
        public async Task<ActionResult<long>> DeleteSupplier(long id)
        {
            await _service.Delete(id);
            //_logger.LogInformation("products", _products);
            return id;
        }

    }
}
