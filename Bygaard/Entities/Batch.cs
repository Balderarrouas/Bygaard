using System;

namespace Bygaard.Entities
{
    public class Batch
    {
        public Guid BatchId { get; set; } = Guid.NewGuid();
        public int BatchNumber { get; set; }
        public string Substrate { get; set; }
        public double AmountOfSubstrate { get; set; }
        public double ProduceSoFar { get; set; }
        public double ProduceTotal { get; set; }
        public double ExpectedProduceTotal { get; set; }
        public DateTime Started { get; set; }
        public DateTime ExpectedFinish { get; set; }
        public DateTime ActualFinish { get; set; }
    }
}