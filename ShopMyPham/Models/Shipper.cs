using System;
using System.Collections.Generic;

namespace ShopMyPham.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string? ShipperName { get; set; }
        public string? Phone { get; set; }
        public string? Company { get; set; }
        public DateTime? Shipdate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
