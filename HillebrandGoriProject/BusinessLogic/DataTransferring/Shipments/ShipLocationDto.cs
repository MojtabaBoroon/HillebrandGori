using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class ShipLocationDto
    {
        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("cityCode")]
        public string CityCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countrySubEntityName")]
        public string CountrySubEntityName { get; set; }

        [JsonProperty("countrySubEntityCode")]
        public string CountrySubEntityCode { get; set; }

        [JsonProperty("townName")]
        public string TownName { get; set; }

        [JsonProperty("townCode")]
        public string TownCode { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("formattedAddress")]
        public List<string> FormattedAddress { get; set; }

        [JsonProperty("postalCode")]
        public int PostalCode { get; set; }
    }
}
