using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace logistics.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController :ControllerBase
    {
        private List<Drivers> drivers = new List<Drivers> {
            new Drivers(),
            new Drivers { 
                id = 2,
                fullname = "farhan",
                id_number = "2134456712"
            }
        };

        [HttpGet]
        [Route("getalldrivers")]
        public ActionResult<List<Drivers>> getAllDriver()
        {
            return Ok(drivers);
        }

        [HttpGet]
        [Route("getdriver/{id}")]
        public ActionResult<Drivers> getDriver(int id)
        {
            return Ok(drivers.FirstOrDefault(d => d.id == id)); 
        }
    }
}