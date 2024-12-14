using Microsoft.EntityFrameworkCore;

namespace SetupRadzorBlazor.Domain
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) 
        {

        }

        public  DbSet<CarEntity> CarInventory { get; set; }
    }
}
