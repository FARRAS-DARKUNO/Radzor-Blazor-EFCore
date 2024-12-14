using SetupRadzorBlazor.Domain;
using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Infrastructure
{
    public interface ICarRepository
    {
        Task AddAsync(CarEntity car);
        Task<IEnumerable<CarEntity>> GetAllAsync();
        Task<CarEntity?> GetByIdAsync(int id);
        IEnumerable<Car> GetCars();
        Task UpdateAsync(CarEntity car);
    }
}