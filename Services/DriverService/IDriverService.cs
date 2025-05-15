using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Services.DriverService
{
    public interface IDriverService
    {
        public Task<ServiceResponse<Drivers>> getDriver(int id);
        public Task<ServiceResponse<List<Drivers>>> getAllDrivers();
        public Task<ServiceResponse<List<Drivers>>> addDriver(Drivers newDriver);
    }
}