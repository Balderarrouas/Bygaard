using System;
using System.Collections.Generic;

namespace Bygaard.Dto
{
    public class SubstrateDto
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public int DaysInGrowthPhase { get; set; }
        public int DaysInOpeningPhase1 { get; set; }
        public int DaysInOpeningPhase2 { get; set; }
        public int DaysInHarvestingPhase { get; set; }
        public Guid StockId { get; set; }
    }
}