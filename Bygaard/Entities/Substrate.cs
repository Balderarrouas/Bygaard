using System;

namespace Bygaard.Entities
{
    public class Substrate
    {
        public Guid SubstrateId { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LatinName { get; set; }
        public int DaysInGrowthPhase { get; set; }
        public int DaysInOpeningPhase1 { get; set; }
        public int DaysInOpeningPhase2 { get; set; }
        public int DaysInHarvestingPhase { get; set; }
        public double KgsInStock { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid StockId { get; set; }
        public Stock Stock { get; set; }
    }
}