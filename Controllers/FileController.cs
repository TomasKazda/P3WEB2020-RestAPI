using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        //https://www.zonerama.cz/api/File
        [HttpPost]
        public IActionResult FileUpload([FromBody] InputFileModel file)
        {
            return Created("https://www.zonerama.cz/api/File/42491eb2-8948-4b88-89b3-9a3913902959", null);
        }

        //https://www.zonerama.cz/api/File/42491eb2-8948-4b88-89b3-9a3913902959
        [HttpGet("{Id}")]
        public IActionResult GetFile(Guid Id)
        {
            return PhysicalFile("path", "image/jpeg");
        }

        //https://www.zonerama.cz/api/File/Private/42491eb2-8948-4b88-89b3-9a3913902959
        [HttpPut("Private/{Id}")]
        public IActionResult SetPrivate(Guid Id)
        {
            return Ok();
        }

        //https://www.zonerama.cz/api/File/Public/42491eb2-8948-4b88-89b3-9a3913902959
        [HttpPut("Public/{Id}")]
        public IActionResult SetPublic(Guid Id)
        {
            return Ok();
        }

    }

    public class InputFileModel
    {

    }
}
