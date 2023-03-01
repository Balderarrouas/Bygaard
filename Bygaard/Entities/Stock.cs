using System;
using System.Collections.Generic;

namespace Bygaard.Entities
{
    public class Stock
    {
        public Guid StockId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public List<Substrate> Substrates { get; set; }
    }
}