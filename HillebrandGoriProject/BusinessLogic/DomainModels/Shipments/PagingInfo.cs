namespace ShipmentApp.DomainModels.Shipments
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int ItemsOnPage { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
