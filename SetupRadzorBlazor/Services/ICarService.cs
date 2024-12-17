using SetupRadzorBlazor.Domain;
using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Services
{
    public interface ICarService
    {
        Task CreateCarAsync(CarEntity car);
        Task DeleteCarAsync(int id);
        IEnumerable<Car> GerCar();
        Task<IEnumerable<CarEntity>> GetAllCars();
        Task UpdateCarService(CarEntity car);
    }
}