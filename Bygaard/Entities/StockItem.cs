using System;

namespace Bygaard.Entities
{
    public class StockItem
    {
        public Guid StockItemId { get; set; } = Guid.NewGuid();
        public string SubstrateName { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}