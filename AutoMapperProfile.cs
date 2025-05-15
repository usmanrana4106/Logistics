using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Drivers, GetDriverDto>();
            CreateMap<AddDriverDto, Drivers>();
        }
    }
}