using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class LastEventDto
    {
        [JsonProperty("_links")]
        public LinkDto Link { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("lastUpdate")]
        public long LastUpdate { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("templateVariables")]
        public List<TemplateVariableDto> TemplateVariables { get; set; }
    }
}
