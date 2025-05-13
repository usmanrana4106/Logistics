using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace logistics.Models
{
    public class Drivers
    {
        public int id { get; set; } = 1;
        public string fullname { get; set; } = "Usman";
        public string id_number { get; set; } = "214456897";
        public string mobile { get; set; } = "0561944624";
        public DriverStatus status { get; set; } = DriverStatus.active;
    }
}