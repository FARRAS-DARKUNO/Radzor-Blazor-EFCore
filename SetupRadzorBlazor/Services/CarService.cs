using SetupRadzorBlazor.Infrastructure;
using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {

            _carRepository = new CarRepository();
        }

        public IEnumerable<Car> GerCar()
        {
            return _carRepository.GetCars();
        }
    }
}
