using System;
using Microsoft.EntityFrameworkCore;

namespace Device.API.Models
{
    public class DeviceContext:DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options):base(options)
        {
            
        
        }
        public DbSet<SmartDevice> Devices { get; set; }
    }
}