namespace ShipmentApp.DomainModels.Shipments
{
    public class Shipment
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Item> Items { get; set; }
    }
}
