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

        private readonly IMapper _mapper;

        public DriverService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetDriverDto>>> getAllDrivers()
        {
            var response = new ServiceResponse<List<GetDriverDto>>();
            var driverslist = _mapper.Map<List<GetDriverDto>>(drivers);
            response.data = driverslist;
            return response;
        }

        public async Task<ServiceResponse<GetDriverDto>> getDriver(int id)
        {
           var driver =  drivers.FirstOrDefault(d => d.id == id); 
           var response = new ServiceResponse<GetDriverDto>();
           response.data = _mapper.Map<GetDriverDto>(driver);;
           return response;
        }

        public async Task<ServiceResponse<List<GetDriverDto>>> addDriver(AddDriverDto newDriver)
        {
            var response = new ServiceResponse<List<GetDriverDto>>();
            var driver = _mapper.Map<Drivers>(newDriver);
            driver.id = drivers.Max(d => d.id) + 1;
            drivers.Add(driver);
            response.data = drivers.Select( d => _mapper.Map<GetDriverDto>(d)).ToList();
            return response;
        }
    }
}