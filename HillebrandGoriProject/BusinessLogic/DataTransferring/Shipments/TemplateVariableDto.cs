using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class TemplateVariableDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("dataTypeFormat")]
        public string DataTypeFormat { get; set; }

        [JsonProperty("resource")]
        public ResourcesDto Resource { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }
}
