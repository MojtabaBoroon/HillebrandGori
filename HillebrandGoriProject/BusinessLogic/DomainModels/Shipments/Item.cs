namespace ShipmentApp.DomainModels.Shipments
{
    public class Item
    {
        public Link Link { get; set; }
        public int Id { get; set; }
        public long ModifiedTimeStamp { get; set; }
        public string ShipFromPartyName { get; set; }
        public ShipLocation ShipFromLocation { get; set; }
        public string ShipFromLocationStatus { get; set; }
        public DateTime EstimatedDepartureDate { get; set; }
        public DateTime ActualDepartureDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string ShipToPartyName { get; set; }
        public ShipLocation ShipToLocation { get; set; }
        public string ShipToLocationStatus { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
        public DateTime ActualArrivalDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string SoldBy { get; set; }
        public string SoldTo { get; set; }
        public LastEvent LastEvent { get; set; }
        public string Status { get; set; }
        public List<References> References { get; set; }
        public Equipment Equipment { get; set; }
        public int Progress { get; set; }
        public string OnTimeStatus { get; set; }
        public Emission Emission { get; set; }
        public Favourite Favourite { get; set; }
        public DateTime ReadyDate { get; set; }
        public string MainModality { get; set; }
    }
}
