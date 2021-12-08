using Edumaq.Service.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EdumaqAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class FileController : Controller
    {
        private IItemService _service;
        public FileController(IItemService service)
        {
            _service = service;
        }
        [HttpPost("/api/upload/image")]
        public async Task<ActionResult<string>> UploadImage()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files[0];
                string folderName = Path.Combine("wwwroot", "images", "institutions", "schoolname", "inventoryimages");
                string pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                
                if (!Directory.Exists(pathToSave))
                {
                    Directory.CreateDirectory(pathToSave);
                }

                if (file.Length > 0)
                {
                    string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string uniqueFileName = String.Concat( Guid.NewGuid().ToString(), fileName);
                    string fullPath = Path.Combine(pathToSave, uniqueFileName);
                    string imagePath = FixURLPath(Path.Combine(folderName, uniqueFileName));
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { imagePath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        private string FixURLPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }
            return path.Replace("\\", "/");
        }
    }
}
