using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Infrastructure
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
    }
}