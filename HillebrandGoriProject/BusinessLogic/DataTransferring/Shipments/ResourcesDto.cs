using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class ResourcesDto
    {
        [JsonProperty("_links")]
        public LinkDto Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
