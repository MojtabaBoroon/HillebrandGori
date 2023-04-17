using ShipmentApp.DomainModels.Dates;

namespace ShipmentApp.Persistence.Abstractions
{
    public interface IShipmentRepository
    {
        Task InsertAsync(List<ShipmentDate> shipmentDates);
    }
}
