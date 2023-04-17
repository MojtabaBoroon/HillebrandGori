using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class EquipmentDto
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("refrigerationOperational")]
        public bool RefrigerationOperational { get; set; }

        [JsonProperty("reeferTemperature")]
        public int ReeferTemperature { get; set; }

        [JsonProperty("reeferTemperatureUnit")]
        public string ReeferTemperatureUnit { get; set; }

        [JsonProperty("fittings")]
        public List<string> Fittings { get; set; }

        [JsonProperty("transportReferences")]
        public List<TransportReferenceDto> TransportReferences { get; set; }

        [JsonProperty("grossWeight")]
        public int GrossWeight { get; set; }

        [JsonProperty("grossWeightUnit")]
        public string GrossWeightUnit { get; set; }

        [JsonProperty("sealNumbers")]
        public List<string> SealNumbers { get; set; }
    }
}
