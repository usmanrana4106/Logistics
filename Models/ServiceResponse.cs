using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logistics.Models
{
    public class ServiceResponse<T>
    {
        public T? data { get; set; }
        public  bool success { get; set; } = true;
        public string message { get; set; } = "";
    }
}