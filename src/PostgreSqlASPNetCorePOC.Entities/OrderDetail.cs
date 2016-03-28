using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PostgreSqlASPNetCorePOC.Entities
{
    public class OrderDetail
    {
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
