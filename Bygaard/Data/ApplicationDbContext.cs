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
        public DbSet<Stock> Stock { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SubstrateConfig());
            builder.ApplyConfiguration(new GrowRoomConfig());
            builder.ApplyConfiguration(new StockConfig());
            base.OnModelCreating(builder);
        }

    }
}