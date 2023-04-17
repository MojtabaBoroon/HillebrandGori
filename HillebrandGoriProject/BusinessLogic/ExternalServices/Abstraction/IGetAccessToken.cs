namespace ShipmentApp.ExternalServices.Abstraction
{
    public interface IGetAccessToken
    {
        Task<string> GetAccessTokenAsync();
    }
}
