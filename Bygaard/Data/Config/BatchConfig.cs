using Bygaard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bygaard.Data.Config
{
    public class BatchConfig : IEntityTypeConfiguration<Batch>
    {
        public void Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.HasKey(batch => batch.BatchId);
            builder.HasQueryFilter(x => x.DeletedAt == null);

           
               
            
        }
    }
}