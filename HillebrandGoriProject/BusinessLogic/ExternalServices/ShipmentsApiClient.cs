using AutoMapper;
using Newtonsoft.Json;
using ShipmentApp.DataTransferring.Shipments;
using ShipmentApp.DomainModels.Shipments;
using ShipmentApp.ExternalServices.Abstraction;
using System.Net.Http.Headers;

namespace ShipmentApp.ExternalServices
{
    public class ShipmentsApiClient : IShipmentsApiClient
    {
        private readonly IMapper _ShipmentMapper;

        private static readonly HttpClient _client = new HttpClient();
        string _shipmentsUrl = "https://api.hillebrandgori.com/v3/shipments";

        public ShipmentsApiClient(IMapper shipmentMapper)
        {
            _ShipmentMapper = shipmentMapper;
        }

        public async Task<Shipment> GetShipmentsAsync(string accessToken)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await _client.GetAsync(_shipmentsUrl);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var apiResult = JsonConvert.DeserializeObject<ShipmentDto>(responseContent);
                var result = MapApiResult(apiResult);

                return result;
            }
            else
            {
                throw new Exception($"Failed to get shipments: {response.StatusCode} {response.ReasonPhrase}");
            }
        }

        private Shipment MapApiResult(ShipmentDto? apiResult)
        {
            return  _ShipmentMapper.Map<Shipment>(apiResult);
        }

        public async Task<Item> GetShipmentByIdAsync(int shipmentId, string accessToken)
        {
            var shipmentUrl = $"{_shipmentsUrl}/{shipmentId}";

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await _client.GetAsync(shipmentUrl);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var apiResult = JsonConvert.DeserializeObject<ItemDto>(responseContent);
                var result = MapItemApiResult(apiResult);

                return result;
            }

            else
            {
                throw new Exception($"Failed to get shipments: {response.StatusCode} {response.ReasonPhrase}");
            }
        }

        private Item MapItemApiResult(ItemDto? apiResult)
        {
            return _ShipmentMapper.Map<Item>(apiResult);
        }
    }
}
