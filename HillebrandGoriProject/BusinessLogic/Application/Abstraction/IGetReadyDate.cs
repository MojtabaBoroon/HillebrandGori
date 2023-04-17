using ShipmentApp.DomainModels.Dates;

namespace ShipmentApp.Application.Abstraction
{
    public interface IGetReadyDate
    {
        Task<List<ShipmentDate>> HandleAsync(); 
    }
}
