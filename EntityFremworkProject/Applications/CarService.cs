using EntityFremworkProject.Models;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFremworkProject.Applications
{
    public class CarService : ICarService
    {
        private readonly ApplecationDbContext _context;
        public CarService(ApplecationDbContext context)
        {
            _context = context;
        }
        public Task<string> CreateCarAsync(Car model)
        {
            throw new NotImplementedException();
        }
    }
}
