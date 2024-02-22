using EntityFremworkProject.Models;

namespace EntityFremworkProject.Applications
{
    public interface ICarService
    {
        public Task<string> CreateCarAsync(Car model);
    }
}
