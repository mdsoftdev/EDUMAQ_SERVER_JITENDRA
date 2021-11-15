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
    public class TaxesController : ControllerBase
    {
        private ITaxService _service;
        public TaxesController(ITaxService service) {
            _service = service;       
        }

        [HttpGet("/api/taxes")]
        public IEnumerable<Tax> GetAllTax()
        {
            //var rng = new Random();
            var test = _service.GetAll();
            return _service.GetAll();
        }

        [HttpGet("/api/taxes/{id}")]
        public async Task<Tax> GetByTaxID(long id)
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


        [HttpPost("/api/taxes")]
        public async Task<ActionResult<TaxDto>> CreateTax(TaxDto taxDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.TaxName == taxDto.TaxName))
                return StatusCode(409, $"Tax already exists.");

            await _service.InsertTax(taxDto.ConvertToModel(taxDto));

            return Ok(taxDto);
        }

        [HttpPut("/api/taxes/{id}")]
        public async Task<ActionResult<TaxDto>>  UpdateSupplierType(long id, TaxDto taxDto)
        {
            if (_service.IsExists(x => x.TaxName == taxDto.TaxName))
                return StatusCode(409, $"Tax already exists.");

            await _service.ModifyTax(id, taxDto.ConvertToModel(taxDto));
            return Ok(taxDto);
        }

        [HttpDelete("/api/taxes/{id}")]
        public async Task<ActionResult<long>> DeleteTax(long id)
        {
            await _service.Delete(id);
            //_logger.LogInformation("products", _products);
            return id;
        }

    }
}
