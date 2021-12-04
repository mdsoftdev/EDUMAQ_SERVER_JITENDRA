using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EdumaqAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class UnitsController : Controller
    {
        private IUnitService _service;
        public UnitsController(IUnitService service)
        {
            _service = service;
        }

        [HttpGet("/api/units")]
        public IEnumerable<Unit> GetAll()
        {
            return _service.GetAll();
        }
    }
}
