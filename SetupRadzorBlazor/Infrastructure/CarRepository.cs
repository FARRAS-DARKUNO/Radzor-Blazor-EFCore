using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Infrastructure
{
    public class CarRepository : ICarRepository
    {

        public IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car("Car3", "Cheetah", 2026, 12000, "H=Diesel", "Blue"),
                new Car("Car4", "Panther", 2027, 20000, "H=Electric", "Red"),
                new Car("Car5", "Cougar", 2028, 18000, "H=Hybrid", "Green"),
                new Car("Car6", "Jaguar", 2029, 25000, "H=Gasolin", "Black"),
                new Car("Car7", "Leopard", 2030, 30000, "H=Electric", "Silver"),
                new Car("Car8", "Tiger", 2024, 17000, "H=Diesel", "Yellow"),
                new Car("Car9", "Lion", 2025, 22000, "H=Hybrid", "White"),
                new Car("Car10", "Puma", 2026, 14000, "H=Gasolin", "Gray"),
                new Car("Car11", "Ocelot", 2027, 16000, "H=Electric", "Gold")
            };
        }
    }
}
