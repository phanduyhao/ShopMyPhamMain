using System;
using System.Collections.Generic;

namespace ShopMyPham.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderStatus { get; set; }
        public int? Deleted { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public string? Note { get; set; }
        public int? ShipperId { get; set; }
        public int? TotalMoney { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual OrderStatus? OrderStatusNavigation { get; set; }
        public virtual Shipper? Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
