using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class ReferencesDto
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
