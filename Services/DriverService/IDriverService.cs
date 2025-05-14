using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Services.DriverService
{
    public interface IDriverService
    {
        public Drivers getDriver(int id);
        public List<Drivers> getAllDrivers();
        public List<Drivers> addDriver(Drivers newDriver);
    }
}