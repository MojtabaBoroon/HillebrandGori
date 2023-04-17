using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class FavouriteDto
    {
        [JsonProperty("_links")]
        public LinkDto Links { get; set; }

        [JsonProperty("favourite")]
        public bool IsFavourite { get; set; }
    }
}