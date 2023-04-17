using Microsoft.AspNetCore.Mvc;
using ShipmentApp.Application.Abstraction;
using ShipmentApp.DomainModels.Dates;
using ShipmentApp.Persistence.Abstractions;

namespace Shipments.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentReadyDateController : Controller
    {
        private readonly IGetReadyDate _getReadyDate;
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentReadyDateController(IGetReadyDate getReadyDate, IShipmentRepository shipmentRepository)
        {
            _getReadyDate = getReadyDate;
            _shipmentRepository = shipmentRepository;
        }

        [HttpPost]
        public async Task<ActionResult<List<ShipmentDate>>> AddShipmentReadyDate()
        {
            var readyDates = await _getReadyDate.HandleAsync();
            await _shipmentRepository.InsertAsync(readyDates);

            return Ok(readyDates);
        }
    }
}
