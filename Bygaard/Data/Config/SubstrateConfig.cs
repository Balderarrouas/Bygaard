using Bygaard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bygaard.Data.Config
{
    public class SubstrateConfig : IEntityTypeConfiguration<Substrate>
    {
        public void Configure(EntityTypeBuilder<Substrate> builder)
        {
            builder.HasKey(substrate => substrate.SubstrateId);
        }


    }
}