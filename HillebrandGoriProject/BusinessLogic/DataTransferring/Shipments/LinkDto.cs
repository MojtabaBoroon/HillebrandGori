using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class LinkDto
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("modifiedTimeStamp")]
        public int ModifiedTimeStamp { get; set; }
    }
}
