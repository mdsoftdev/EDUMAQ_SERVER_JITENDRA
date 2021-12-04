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
    public class ColorsController : Controller
    {
        private IColorService _service;
        public ColorsController(IColorService service)
        {
            _service = service;
        }

        [HttpGet("/api/colors")]
        public IEnumerable<Color> GetAll()
        {
            return _service.GetAll();
        }
    }
}
