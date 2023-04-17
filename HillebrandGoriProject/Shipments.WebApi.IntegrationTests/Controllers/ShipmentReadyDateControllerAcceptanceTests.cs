using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;
using ShipmentApp.DomainModels.Dates;
using ShipmentApp.DomainModels.Shipments;
using ShipmentApp.ExternalServices.Abstraction;
using ShipmentApp.Persistence.Abstractions;
using System.Net;
using System.Text;

namespace Shipments.WebApi.IntegrationTests.Controllers
{
    public class ShipmentReadyDateControllerAcceptanceTests : IClassFixture<TestStartup<Program>>
    {
        private readonly TestStartup<Program> _factory;

        private readonly Mock<IShipmentsApiClient> _shipmentsApiClientMock;
        private readonly Mock<IShipmentRepository> _shipmentRepositoryMock;
        private readonly HttpClient _client;

        private Shipment _shipment;

        public ShipmentReadyDateControllerAcceptanceTests(TestStartup<Program> factory)
        {
            _factory = factory;

            _shipmentsApiClientMock = new Mock<IShipmentsApiClient>();
            _shipmentRepositoryMock = new Mock<IShipmentRepository>();
            _client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddSingleton(_shipmentsApiClientMock.Object);
                    services.AddSingleton(_shipmentRepositoryMock.Object);
                });
            }).CreateClient();

            _shipment = CreateShipment();
        }

        private Shipment CreateShipment()
        {
            return new Shipment
            {
                Items = new List<Item>
                {
                    new Item
                    {
                        Id = 1,
                        ReadyDate = new DateTime(2019,06,05)
                    },
                    new Item
                    {
                        Id= 2,
                        ReadyDate = new DateTime(2020,06,08)
                    },
                    new Item
                    {
                        Id = 3,
                        ReadyDate = new DateTime(2022,06,08)
                    }
                }
            };
        }

        [Fact]
        public async Task AddShipmentReadyDate_InternalApiIsCalled_ShipmentsApiIsCalled()
        {
            // Arrang
            Shipment shipment = new()
            {
                Items = new List<Item>
                {
                    new Item()
                    {
                        Id = 1
                    }
                } 
            };

            _shipmentsApiClientMock.Setup(x => x.GetShipmentsAsync(It.IsAny<string>())).ReturnsAsync(shipment);
            _shipmentsApiClientMock.Setup(x => x.GetShipmentByIdAsync(It.IsAny<int>(), It.IsAny<string>()))
                .ReturnsAsync(shipment.Items.FirstOrDefault());
            var requestBody = new StringContent("", Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync("/api/ShipmentReadyDate", requestBody);

            //Assert
            _shipmentsApiClientMock.Verify(x => x.GetShipmentsAsync(It.IsAny<string>()), Times.Once);
            _shipmentsApiClientMock.Verify(x => x.GetShipmentByIdAsync(It.IsAny<int>(), It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async Task AddShipmentReadyDate_InternalApiIsCalled_GetShipmentByIdAsyncIsCalled()
        {
            // Arrang
            _shipmentsApiClientMock.Setup(x => x.GetShipmentsAsync(It.IsAny<string>())).ReturnsAsync(_shipment);
            foreach (var item in _shipment.Items)
            {
                _shipmentsApiClientMock.Setup(x => x.GetShipmentByIdAsync(item.Id, It.IsAny<string>()))
                    .ReturnsAsync(item);
            }
            var requestBody = new StringContent("", Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync("/api/ShipmentReadyDate", requestBody);

            //Assert
            _shipmentsApiClientMock.Verify(x => x.GetShipmentByIdAsync(It.IsAny<int>(), It.IsAny<string>()), Times.Exactly(_shipment.Items.Count));
        }

        [Fact]
        public async Task AddShipmentReadyDate_InternalApiIsCalled_ShipmentRepositoryIsCalled()
        {
            // Arrang
            Shipment shipment = new()
            {
                Items = new List<Item>
                {
                    new Item()
                    {
                        Id = 1
                    }
                }
            };

            _shipmentsApiClientMock.Setup(x => x.GetShipmentsAsync(It.IsAny<string>())).ReturnsAsync(shipment);
            _shipmentsApiClientMock.Setup(x => x.GetShipmentByIdAsync(It.IsAny<int>(), It.IsAny<string>()))
                .ReturnsAsync(shipment.Items.FirstOrDefault());
            var requestBody = new StringContent("", Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync("/api/ShipmentReadyDate", requestBody);

            //Assert
            _shipmentRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<List<ShipmentDate>>()), Times.Once);
        }

        [Fact]
        public async Task AddShipmentReadyDate_InternalApiIsCalled_ReadyDatesIsReturned()
        {
            // Arrang
            _shipmentsApiClientMock.Setup(x => x.GetShipmentsAsync(It.IsAny<string>())).ReturnsAsync(_shipment);
            foreach (var item in _shipment.Items)
            {
                _shipmentsApiClientMock.Setup(x => x.GetShipmentByIdAsync(item.Id, It.IsAny<string>()))
                    .ReturnsAsync(item);
            }
            var requestBody = new StringContent("", Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync("/api/ShipmentReadyDate", requestBody);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<List<ShipmentDate>>(responseContent);
            Assert.Equal(_shipment.Items.Count, responseModel.Count);
            for (int i = 0; i < responseModel.Count; i++)
            {
                Assert.Equal(_shipment.Items.ElementAt(i).ReadyDate, responseModel.ElementAt(i).ReadyDate);
                Assert.Equal(_shipment.Items.ElementAt(i).ReadyDate, responseModel.ElementAt(i).ReadyDate);
            }
        }
    }
}
