namespace ShipmentApp.DomainModels.Shipments
{
    public class ShipLocation
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountrySubEntityName { get; set; }
        public string CountrySubEntityCode { get; set; }
        public string TownName { get; set; }
        public string TownCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public List<string> FormattedAddress { get; set; }
        public int PostalCode { get; set; }
    }
}
