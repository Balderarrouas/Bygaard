using System;

namespace Bygaard.Entities
{
    public class Substrate
    {
        public Guid SubstrateId { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LatinName { get; set; }
        public int DaysToGrow { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
       
    }
}