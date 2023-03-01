using Bygaard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bygaard.Data.Config
{
    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(stock => stock.StockId);

            builder.HasData(
                new Stock
                {
                    Name = "Main Storage"
                }
            );
        }
    }
}