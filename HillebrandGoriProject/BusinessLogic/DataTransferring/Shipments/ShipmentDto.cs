using Newtonsoft.Json;

namespace ShipmentApp.DataTransferring.Shipments
{
    public class ShipmentDto
    {
        [JsonProperty("_pagingInfo")]
        public PagingInfoDto PagingInfo { get; set; }

        [JsonProperty("items")]
        public List<ItemDto> Items { get; set; }
    }
}
