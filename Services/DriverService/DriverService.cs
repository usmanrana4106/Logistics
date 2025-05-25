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
        private readonly DataContext _context;

        public DriverService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetDriverDto>>> getAllDrivers()
        {
            var response = new ServiceResponse<List<GetDriverDto>>();
            var dblist = await _context.Drivers.ToListAsync();
            var driverslist = _mapper.Map<List<GetDriverDto>>(dblist);
            response.data = driverslist;
            return response;
        }

        public async Task<ServiceResponse<GetDriverDto>> getDriver(int id)
        {
           var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.id == id); 
           var response = new ServiceResponse<GetDriverDto>();
           response.data = _mapper.Map<GetDriverDto>(driver);;
           return response;
        }

        public async Task<ServiceResponse<List<GetDriverDto>>> addDriver(AddDriverDto newDriver)
        {
            var response = new ServiceResponse<List<GetDriverDto>>();
            try
            {
                var driver = _mapper.Map<Drivers>(newDriver);
                _context.Drivers.Add(driver);
                await _context.SaveChangesAsync();
                response.data = await _context.Drivers.Select(d => _mapper.Map<GetDriverDto>(d)).ToListAsync();
            }
            catch (Exception Exception)
            {
                response.success = false;
                response.message = Exception.Message;
            }
            return response;
        }


        public async Task<ServiceResponse<GetDriverDto>> updateDriver(UpdateDriverDto updatedDriver)
        {
            var response = new ServiceResponse<GetDriverDto>();
            try
            {
                var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.id == updatedDriver.id);
                if (driver == null)
                    throw new Exception($"Driver Not Found at the Id {updatedDriver.id}");
                driver.fullname = updatedDriver.fullname;
                driver.id_number = updatedDriver.id_number;
                driver.mobile = updatedDriver.mobile;
                driver.status = updatedDriver.status;

                await _context.SaveChangesAsync();

                response.data = _mapper.Map<GetDriverDto>(driver);


            }
            catch (Exception Exception)
            {
                response.success = false;
                response.message = Exception.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetDriverDto>>> deleteDriver(int id)
        {
            var response = new ServiceResponse<List<GetDriverDto>>();
            try
            {
                var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.id == id);
                if (driver == null)
                    throw new Exception($"Driver is not found on the given ID {id}");
                _context.Drivers.Remove(driver);
                await _context.SaveChangesAsync();
                // response.data = _mapper.Map<List<GetDriverDto>>(drivers);    
                response.data = await _context.Drivers.Select(d => _mapper.Map<GetDriverDto>(d)).ToListAsync();   
            }
            catch (Exception Exception)
            {
                response.success = false;
                response.message = Exception.Message;
            }

            return response;
        }
    }
}