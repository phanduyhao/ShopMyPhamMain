using System;
using System.Collections.Generic;

namespace ShopMyPham.Models
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public string? Description { get; set; }
        public int Ordering { get; set; }
    }
}
