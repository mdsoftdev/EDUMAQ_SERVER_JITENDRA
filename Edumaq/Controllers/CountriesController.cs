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
    public class CountriesController : ControllerBase
    {
        private ICountryService _service;
        public CountriesController(ICountryService service) {
            _service = service;       
        }

        [HttpGet("/api/countries")]
        public IEnumerable<Country> GetAllCountry()
        {
            //var rng = new Random();
            return _service.GetAll();
        }

        [HttpGet("/api/countries/{id}")]
        public async Task<Country> GetByCountryID(long id)
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


        //[HttpPost("/api/taxes")]
        //public async Task<ActionResult<TaxDto>> CreateTax(TaxDto taxDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (_service.IsExists(x => x.TaxName == taxDto.TaxName))
        //        return StatusCode(409, $"Tax already exists.");

        //    await _service.InsertTax(taxDto.ConvertToModel(taxDto));

        //    return Ok(taxDto);
        //}

        //[HttpPut("/api/taxes/{id}")]
        //public async Task<ActionResult<TaxDto>>  UpdateSupplierType(long id, TaxDto taxDto)
        //{
        //    if (_service.IsExists(x => x.TaxName == taxDto.TaxName))
        //        return StatusCode(409, $"Tax already exists.");

        //    await _service.ModifyTax(id, taxDto.ConvertToModel(taxDto));
        //    return Ok(taxDto);
        //}

        //[HttpDelete("/api/taxes/{id}")]
        //public async Task<ActionResult<long>> DeleteTax(long id)
        //{
        //    await _service.Delete(id);
        //    //_logger.LogInformation("products", _products);
        //    return id;
        //}

    }
}
