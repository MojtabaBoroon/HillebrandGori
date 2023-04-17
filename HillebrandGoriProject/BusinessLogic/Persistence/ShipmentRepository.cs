using ShipmentApp.DomainModels.Dates;
using ShipmentApp.Persistence.Abstractions;
using ShipmentApp.Persistence.DataAccessContext;

namespace ShipmentApp.Persistence
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly HillebrandGoriDbContext _hillebrandGoriDbContext;

        public ShipmentRepository(HillebrandGoriDbContext hillebrandGoriDbContext)
        {
            _hillebrandGoriDbContext = hillebrandGoriDbContext;
        }

        public async Task InsertAsync(List<ShipmentDate> shipmentDates)
        {
            ClearDbTables();
            await _hillebrandGoriDbContext.ShipmentDate.AddRangeAsync(shipmentDates);
            await _hillebrandGoriDbContext.SaveChangesAsync();
        }

        private void ClearDbTables()
        {
            var dbReadyDates = _hillebrandGoriDbContext.ShipmentDate;

            if (dbReadyDates != null)
            {
                _hillebrandGoriDbContext.ShipmentDate.RemoveRange(dbReadyDates);
                _hillebrandGoriDbContext.SaveChanges();
            }
        }
    }    
}
