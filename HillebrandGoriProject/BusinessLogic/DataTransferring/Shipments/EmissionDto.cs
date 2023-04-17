using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class EmissionDto
    {
        [JsonProperty("calculation")]
        public string Calculation { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}