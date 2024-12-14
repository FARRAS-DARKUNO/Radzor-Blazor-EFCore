using SetupRadzorBlazor.Domain;
using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GerCar();
        Task<IEnumerable<CarEntity>> GetAllCars();
    }
}