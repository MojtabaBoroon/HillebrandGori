using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Moq;
using ShipmentApp.ExternalServices.Abstraction;
using ShipmentApp.Persistence.Abstractions;

namespace Shipments.WebApi.IntegrationTests.Controllers
{
    public class TestStartup<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        public Mock<IShipmentsApiClient> shipmentMock { get; private set; }
        public Mock<IShipmentRepository> shipmentRepositoryMock { get; private set; }

        public TestStartup()
        {
            shipmentMock = new Mock<IShipmentsApiClient>();
            shipmentRepositoryMock = new Mock<IShipmentRepository>();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.RemoveAll<IShipmentsApiClient>();
                services.RemoveAll<IShipmentRepository>();

                services.AddSingleton(shipmentMock.Object);
                services.AddSingleton(shipmentRepositoryMock.Object);
            });
        }
    }
}