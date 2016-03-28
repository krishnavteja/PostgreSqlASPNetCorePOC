using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PostgreSqlASPNetCorePOC.Entities
{
    // >dnx . ef migration add testMigration

    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
