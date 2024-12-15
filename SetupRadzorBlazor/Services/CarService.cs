using SetupRadzorBlazor.Domain;
using SetupRadzorBlazor.Infrastructure;
using SetupRadzorBlazor.Models;


namespace SetupRadzorBlazor.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {

            _carRepository = carRepository;
        }

        public async Task<IEnumerable<CarEntity>> GetAllCars()
        {
            return await _carRepository.GetAllAsync();
        }

        public async Task UpdateCarService(CarEntity car)
        {
            await _carRepository.UpdateAsync(car);
        }

        public IEnumerable<Car> GerCar()
        {
            return _carRepository.GetCars();
        }
    }
}
