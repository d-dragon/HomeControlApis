using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Device.API.Models;
namespace Device.API.Repositories
{
    public class SQLRepository : ISensorRepository
    {
        private readonly DeviceContext _context;
        public SQLRepository(DeviceContext context)
        {
            _context = context;
        }
        public string GetSensorCapabilities(int DeviceId)
        {
            return _context.Devices.Find(DeviceId).DeviceCapability;
        }

        public string GetSensorName(int DeviceId)
        {
            return _context.Devices.Find(DeviceId).DeviceName;
        }
    }
}