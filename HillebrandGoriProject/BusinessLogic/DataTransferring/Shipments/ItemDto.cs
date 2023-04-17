using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class ItemDto
    {
        [JsonProperty("_links")]
        public LinkDto Link { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("modifiedTimeStamp")]
        public long ModifiedTimeStamp { get; set; }

        [JsonProperty("shipFromPartyName")]
        public string ShipFromPartyName { get; set; }

        [JsonProperty("shipLocation")]
        public ShipLocationDto ShipFromLocation { get; set; }

        [JsonProperty("shipFromLocationStatus")]
        public string ShipFromLocationStatus { get; set; }

        [JsonProperty("estimatedDepartureDate")]
        public DateTime EstimatedDepartureDate { get; set; }

        [JsonProperty("actualDepartureDate")]
        public DateTime ActualDepartureDate { get; set; }

        [JsonProperty("departureDate")]
        public DateTime DepartureDate { get; set; }

        [JsonProperty("shipToPartyName")]
        public string ShipToPartyName { get; set; }

        [JsonProperty("shipToLocation")]
        public ShipLocationDto ShipToLocation { get; set; }

        [JsonProperty("shipToLocationStatus")]
        public string ShipToLocationStatus { get; set; }

        [JsonProperty("estimatedArrivalDate")]
        public DateTime EstimatedArrivalDate { get; set; }

        [JsonProperty("actualArrivalDate")]
        public DateTime ActualArrivalDate { get; set; }

        [JsonProperty("arrivalDate")]
        public DateTime ArrivalDate { get; set; }

        [JsonProperty("soldBy")]
        public string SoldBy { get; set; }

        [JsonProperty("soldTo")]
        public string SoldTo { get; set; }

        [JsonProperty("lastEvent")]
        public LastEventDto LastEvent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("references")]
        public List<ReferencesDto> References { get; set; }

        [JsonProperty("equipment")]
        public EquipmentDto Equipment { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("onTimeStatus")]
        public string OnTimeStatus { get; set; }

        [JsonProperty("emission")]
        public EmissionDto Emission { get; set; }

        [JsonProperty("favourite")]
        public FavouriteDto Favourite { get; set; }

        [JsonProperty("readyDate")]
        public DateTime ReadyDate { get; set; }

        [JsonProperty("mainModality")]
        public string MainModality { get; set; }
    }
}
