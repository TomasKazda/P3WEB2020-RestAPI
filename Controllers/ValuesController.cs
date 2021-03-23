using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hello()
        {
            var dataResult = new DataViewModel { Jmeno = "Franta", Prijmeni = "Vopička" };
            return Ok(dataResult);
        }
    }

    public class DataViewModel
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
    }
}
