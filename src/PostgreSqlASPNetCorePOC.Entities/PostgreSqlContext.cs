using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using PostgreSqlASPNetCorePOC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSqlASPNetCorePOC.Entities
{
    // >dnx . ef migration add testMigration
    public class PostgreSqlContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>()
                .HasKey(o => new { o.OrderId, o.ProductId });

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
           .AddJsonFile("config.json")
           .AddEnvironmentVariables();
            var configuration = builder.Build();

            var sqlConnectionString = configuration["PostgreSqlProvider:ConnectionString"];

            optionsBuilder.UseNpgsql(sqlConnectionString);
        }
    }

}
