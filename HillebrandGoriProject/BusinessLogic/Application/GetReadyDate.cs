using ShipmentApp.Application.Abstraction;
using ShipmentApp.DomainModels.Dates;
using ShipmentApp.DomainModels.Shipments;
using ShipmentApp.ExternalServices.Abstraction;

namespace ShipmentApp.Application
{
    public class GetReadyDate : IGetReadyDate
    {
        private readonly IShipmentsApiClient _shipmentsApiClient;
        private readonly IGetAccessToken _getAccessToken;

        private string _accessToken;

        public GetReadyDate(IShipmentsApiClient shipmentsApiClient, IGetAccessToken getAccessToken)
        {
            _shipmentsApiClient = shipmentsApiClient;
            _getAccessToken = getAccessToken;
        }

        public async Task<List<ShipmentDate>> HandleAsync()
        {
            _accessToken = await GetAccessTokenAsync();

            var shipment = await _shipmentsApiClient.GetShipmentsAsync(_accessToken);

            var items = await GetShipmentItems(shipment);

            return GetReadyDates(items);
        }

        private async Task<string> GetAccessTokenAsync()
        {
            return await _getAccessToken.GetAccessTokenAsync();
        }

        private async Task<List<Item>> GetShipmentItems(Shipment shipment)
        {
            List<Task<Item>> tasks = new();
            foreach (var item in shipment.Items)
            {
                tasks.Add(_shipmentsApiClient.GetShipmentByIdAsync(item.Id, _accessToken));
            }
            await Task.WhenAll(tasks);
            return tasks.Select(x => x.Result).ToList();
        }

        private static List<ShipmentDate> GetReadyDates(List<Item> items)
        {
            List<ShipmentDate> readyDates = new();
            foreach (var item in items)
            {
                readyDates.Add(new ShipmentDate
                {
                    ReadyDate = item.ReadyDate
                });
            }

            return readyDates;
        }
    }
}
