using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Services.DriverService
{
    public class DriverService : IDriverService
    {
        private List<Drivers> drivers = new List<Drivers> {
            new Drivers(),
            new Drivers { 
                id = 2,
                fullname = "farhan",
                id_number = "2134456712"
            }
        };
        public async Task<ServiceResponse<List<Drivers>>> getAllDrivers()
        {
            var response = new ServiceResponse<List<Drivers>>();
            response.data = drivers;
            return response;
        }

        public async Task<ServiceResponse<Drivers>> getDriver(int id)
        {
           var driver =  drivers.FirstOrDefault(d => d.id == id); 
           var response = new ServiceResponse<Drivers>();
           response.data = driver;
           return response;
        }

        public async Task<ServiceResponse<List<Drivers>>> addDriver(Drivers newDriver)
        {
            drivers.Add(newDriver);
            var response = new ServiceResponse<List<Drivers>>();
            response.data = drivers;
            return response;
        }
    }
}