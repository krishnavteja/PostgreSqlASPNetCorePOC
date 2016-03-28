using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PostgreSqlASPNetCorePOC.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public DateTime ShippedDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }
    }
}
