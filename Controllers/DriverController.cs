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
        public async Task<ActionResult<ServiceResponse<List<Drivers>>>> getAllDriver()
        {
            return Ok(await _DriverService.getAllDrivers());
        }

        [HttpGet]
        [Route("getdriver/{id}")]
        public async Task<ActionResult<ServiceResponse<Drivers>>> getDriver(int id)
        {
            return Ok(await _DriverService.getDriver(id)); 
        }

        [HttpPost]
        [Route("addDriver")]
        public async Task<ActionResult<ServiceResponse<List<Drivers>>>> addDriver(Drivers newDriver)
        {
            return Ok(await _DriverService.addDriver(newDriver));
        }
    }
}