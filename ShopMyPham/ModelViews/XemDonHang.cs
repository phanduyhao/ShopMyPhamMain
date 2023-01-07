using ShopMyPham.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ShopMyPham.ModelViews
{
    public class XemDonHang
    {
        [Key]
        public int Id { get; set; }
        public Order? DonHang { get; set; }
        public List<OrderDetail>? ChiTietDonHang { get; set; }
    }
}
