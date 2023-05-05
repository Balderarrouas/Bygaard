using System;
using System.Collections.Generic;

namespace Bygaard.Dto
{
    public class SubstrateDto
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public int DaysToGrow { get; set; }
        public Guid StockId { get; set; }
    }
}