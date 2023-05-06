using System;

namespace Bygaard.Entities
{
    public class Batch
    {
        public Guid BatchId { get; set; } = Guid.NewGuid();
        public string Substrate { get; set; }
        public double KilosOfSubstrate { get; set; }
        public double KilosOfProduce { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}