namespace ShipmentApp.DomainModels.Shipments
{
    public class TemplateVariable
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        public string DataTypeFormat { get; set; }
        public Resources Resource { get; set; }
        public bool Primary { get; set; }
    }
}
