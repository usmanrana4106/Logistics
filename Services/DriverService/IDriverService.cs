using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Logistics.Services.DriverService
{
    public interface IDriverService
    {
        public Task<ServiceResponse<GetDriverDto>> getDriver(int id);
        public Task<ServiceResponse<List<GetDriverDto>>> getAllDrivers();
        public Task<ServiceResponse<List<GetDriverDto>>> addDriver(AddDriverDto newDriver);
        public Task<ServiceResponse<GetDriverDto>> updateDriver(UpdateDriverDto updatedDriver);
    }
}