using ShipmentApp.DataTransferring.Shipments;

namespace ShipmentApp.DomainModels.Shipments
{
    public class Equipment
    {
        public string Number { get; set; }
        public string Classification { get; set; }
        public string Type { get; set; }
        public bool RefrigerationOperational { get; set; }
        public int ReeferTemperature { get; set; }
        public string ReeferTemperatureUnit { get; set; }
        public List<string> Fittings { get; set; }
        public List<TransportReference> TransportReferences { get; set; }
        public int GrossWeight { get; set; }
        public string GrossWeightUnit { get; set; }
        public List<string> SealNumbers { get; set; }
    }
}
