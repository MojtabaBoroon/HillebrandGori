namespace ShipmentApp.DomainModels.Shipments
{
    public class LastEvent
    {
        public Link Link { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public long LastUpdate { get; set; }
        public string Text { get; set; }
        public string Template { get; set; }
        public List<TemplateVariable> TemplateVariables { get; set; }
    }
}
