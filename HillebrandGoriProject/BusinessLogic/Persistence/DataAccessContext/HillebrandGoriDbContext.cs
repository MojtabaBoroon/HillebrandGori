using ShipmentApp.DomainModels.Dates;
using Microsoft.EntityFrameworkCore;

namespace ShipmentApp.Persistence.DataAccessContext
{
    public class HillebrandGoriDbContext : DbContext
    {
        public DbSet<ShipmentDate> ShipmentDate { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog =HillebrandGoriDb;Integrated Security=True;Encrypt=False");
        }
    }
}
