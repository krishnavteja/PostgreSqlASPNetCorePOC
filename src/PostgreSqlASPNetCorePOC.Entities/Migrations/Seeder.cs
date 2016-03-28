using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSqlASPNetCorePOC.Entities.Migrations
{
    public class Seeder
    {
        private readonly PostgreSqlContext Context;

        private readonly Guid BatProductId = Guid.Parse("3721D2CE-F654-4D44-886D-EE51D87F797B");
        private readonly Guid BallProductId = Guid.Parse("FDE50A9F-156F-404D-AF89-403A9A9716E3");
        private readonly Guid GlovesProductId = Guid.Parse("B057DCFB-8776-4A35-9D71-7F7A99F4C2F3");

        public Seeder(PostgreSqlContext context)
        {
            this.Context = context;
        }

        public async Task EnsureSeedData()
        {
            // Seed Hotel data
            SeedProducts(BatProductId, "Baseball Bat", "Baseball Louisville slugger bat", 99);
            SeedProducts(BallProductId, "Baseball Ball", "Baseball Number 5 Leather Ball", 29);
            SeedProducts(GlovesProductId, "Baseball Gloves", "Baseball Leather Gloves", 89);

            await this.Context.SaveChangesAsync();
        }

        private void SeedProducts(Guid id, string name, string description, decimal price)
        {
            if (!this.Context.Products.Any(h => h.Id == id))
            {
                this.Context.Products.Add(new Product
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price
                });
            }
        }
    }
}
