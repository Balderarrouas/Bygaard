using Bygaard.Data.Config;
using Bygaard.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bygaard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<Substrate> Substrates { get; set; }
        public DbSet<GrowRoom> GrowRooms { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<Batch> Batches { get; set; }
        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SubstrateConfig());
            builder.ApplyConfiguration(new StockItemConfig());
            builder.ApplyConfiguration(new BatchConfig());
            builder.ApplyConfiguration(new GrowRoomConfig());
            
            base.OnModelCreating(builder);
        }

    }
}