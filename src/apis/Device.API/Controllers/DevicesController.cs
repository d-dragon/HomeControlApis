using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Device.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Devices : ControllerBase
    {
        // GET api/devices
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "LightBulb", "Switch" };
        }

        // GET api/devices/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Light";
        }

        // POST api/devices
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/devices/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/devices/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
