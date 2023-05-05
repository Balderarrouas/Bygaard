using Bygaard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bygaard.Data.Config
{
    public class StockItemConfig : IEntityTypeConfiguration<StockItem>
    {
        public void Configure(EntityTypeBuilder<StockItem> builder)
        {
            builder.HasKey(stock => stock.StockItemId);
            builder.HasQueryFilter(x => x.DeletedAt == null);

           
               
            
        }
    }
}