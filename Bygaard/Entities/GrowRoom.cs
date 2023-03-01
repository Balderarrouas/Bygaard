using System;

namespace Bygaard.Entities
{
    public class GrowRoom
    {
        public Guid GrowRoomId { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int NumberOfTrolleys { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}