using Microsoft.EntityFrameworkCore;
using SetupRadzorBlazor.Domain;
using SetupRadzorBlazor.Models;

namespace SetupRadzorBlazor.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDbContext _context;

        public CarRepository(CarDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarEntity>> GetAllAsync()
        {
            return await _context.CarInventory.ToListAsync();
        }

        public async Task<CarEntity?> GetByIdAsync(int id)
        {
            return await _context.CarInventory.FindAsync(id);
        }

        public async Task AddAsync(CarEntity car)
        {
            await _context.CarInventory.AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CarEntity car)
        {
             _context.CarInventory.Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var car = await _context.CarInventory.FindAsync(id);
            if (car != null)
            {
                _context.CarInventory.Remove(car);
                await _context.SaveChangesAsync();
            }

        }

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
