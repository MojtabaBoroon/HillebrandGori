using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class TransportReferenceDto
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}