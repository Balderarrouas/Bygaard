namespace Bygaard.Models
{
    public class AverageResponse
    {
        public string SubstrateName { get; set; }
        public double TotalSubstrate { get; set; }
        public double TotalProduce { get; set; }
        public double AverageProducePerKiloOfSubstrate { get; set; }
    }
}