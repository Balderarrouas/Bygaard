using System;
using Bygaard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bygaard.Data.Config
{
    public class GrowRoomConfig : IEntityTypeConfiguration<GrowRoom>
    {
        public void Configure(EntityTypeBuilder<GrowRoom> builder)
        {
            builder.HasKey(growroom => growroom.GrowRoomId);
            
            builder.HasData(
                new GrowRoom
                {
                    Name = "1",
                    NumberOfTrolleys = 16,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new GrowRoom
                {
                    Name = "2",
                    NumberOfTrolleys = 16,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new GrowRoom
                {
                    Name = "3",
                    NumberOfTrolleys = 16,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new GrowRoom
                {
                    Name = "4",
                    NumberOfTrolleys = 16,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new GrowRoom
                {
                    Name = "5",
                    NumberOfTrolleys = 16,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new GrowRoom
                {
                    Name = "6",
                    NumberOfTrolleys = 16,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
    }
}