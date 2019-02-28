using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Device.API.Models;

namespace Device.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Devices : ControllerBase
    {
        private readonly DeviceContext _context;

        public Devices(DeviceContext context)
        {
            _context = context;
        }
        // GET api/devices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmartDevice>>> GetDeviceList()
        {
            return await _context.Devices.ToListAsync();
        }

        // GET api/devices/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Light";
        }

        // POST api/devices
        [HttpPost]
        public async Task<ActionResult<SmartDevice>> PostDevice(SmartDevice device)
        {
            _context.Devices.Add(device);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof (Get), new { id = device.DeviceId}, device);
        }

        // PUT api/devices/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/devices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDevice(int id)
        {
            SmartDevice device = await _context.Devices.FindAsync(id);
            if (device == null)
            {
                return NotFound();
            }
            _context.Devices.Remove(device);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
