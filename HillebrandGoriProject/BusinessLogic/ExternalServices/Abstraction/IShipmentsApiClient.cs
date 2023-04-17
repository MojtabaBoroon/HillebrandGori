using ShipmentApp.DataTransferring.Shipments;
using ShipmentApp.DomainModels.Shipments;

namespace ShipmentApp.ExternalServices.Abstraction
{
    public interface IShipmentsApiClient
    {
        Task<Shipment> GetShipmentsAsync(string accessToken);
        Task<Item> GetShipmentByIdAsync(int shipmentId, string accessToken);
    }
}
