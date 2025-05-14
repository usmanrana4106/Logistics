using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Services.DriverService;
using Microsoft.AspNetCore.Mvc;

namespace logistics.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController :ControllerBase
    {
        private readonly IDriverService _DriverService;

        public DriverController(IDriverService driverService)
        {
            _DriverService = driverService;
        }

        [HttpGet]
        [Route("getalldrivers")]
        public ActionResult<List<Drivers>> getAllDriver()
        {
            return Ok(_DriverService.getAllDrivers());
        }

        [HttpGet]
        [Route("getdriver/{id}")]
        public ActionResult<Drivers> getDriver(int id)
        {
            return Ok(_DriverService.getDriver(id)); 
        }

        [HttpPost]
        [Route("addDriver")]
        public ActionResult <List<Drivers>> addDriver(Drivers newDriver)
        {
            return Ok(_DriverService.addDriver(newDriver));
        }
    }
}