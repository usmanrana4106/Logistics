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
        public List<Drivers> getAllDrivers()
        {
            return drivers;
        }

        public Drivers getDriver(int id)
        {
           var driver =  drivers.FirstOrDefault(d => d.id == id); 
           if(driver is not null)
            return driver;

            throw new Exception("Driver Not Exist");
        }

        public List<Drivers> addDriver(Drivers newDriver)
        {
            drivers.Add(newDriver);
            return drivers;
        }
    }
}