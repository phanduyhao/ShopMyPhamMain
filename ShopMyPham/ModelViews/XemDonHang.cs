using System;
using System.Collections.Generic;
using ShopMyPham.Models;

namespace ShopMyPham.ModelViews
{
    public class XemDonHang
    {
        public Order? DonHang { get; set; }
        public List<OrderDetail>? ChiTietDonHang { get; set; }
    }
}
