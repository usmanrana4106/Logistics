using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Dtos.Drivers
{
    public class AddDriverDto
    {
        public string fullname { get; set; } = "Usman";
        public string id_number { get; set; } = "214456897";
        public string mobile { get; set; } = "0561944624";
        public DriverStatus status { get; set; } = DriverStatus.active;
    }
}