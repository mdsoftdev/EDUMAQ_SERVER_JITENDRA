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
    public class AcademicsController : ControllerBase
    {
        private IAcademicYearService _service;
        public AcademicsController(IAcademicYearService service) {
            _service = service;       
        }

        [HttpGet("/api/academics")]
        public IEnumerable<AcademicYear> GetAllAcademicYear()
        {
            //var rng = new Random();
            var test = _service.GetAll();
            return _service.GetAll();
        }

        [HttpGet("/api/academics/{id}")]
        public async Task<AcademicYear> GetByAcademicYearID(long id)
        {
            //var rng = new Random();
            return await _service.GetById(id);
        }

        [HttpGet("/api/academics/[action]")]
        public ActionResult<bool> IsCurrentAcademicYearExits()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return _service.IsCurrentAcademicyearExists();
        }


        [HttpPost("/api/academics")]
        public ActionResult<AcademicYearDto> CreateAcademicYear(AcademicYearDto academicyearDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.IsExists(x => x.Name == academicyearDto.Name))
                return StatusCode(409, $"Academic Year already exists.");

            _service.InsertAcademicYear(academicyearDto.ConvertToModel(academicyearDto));

            return Ok(academicyearDto);
        }

        [HttpPut("/api/academics/{id}")]
        public ActionResult<AcademicYearDto> UpdateAcademicYear(long id, AcademicYearDto academicyearDto)
        {
            _service.ModifyAcademicYear(id, academicyearDto.ConvertToModel(academicyearDto));
            return Ok(academicyearDto);
        }

        [HttpDelete("/api/academics/{id}")]
        public ActionResult<long> DeleteAcademicYear(long id)
        {
            _service.Delete(id);
            //_logger.LogInformation("products", _products);
            return id;
        }

    }
}
