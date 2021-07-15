using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheesyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileServerController : ControllerBase
    {
        [HttpGet("{filename}")]
        public IActionResult Get(string filename)
        {
            Regex rg = new Regex(@"^cheese[0-9]+\.jpg$");
            if (!rg.Match(filename).Success)
            {
                return NotFound();
            }
            Byte[] b = System.IO.File.ReadAllBytes(filename);
            return File(b, "image/jpeg");
        }
    }
}
