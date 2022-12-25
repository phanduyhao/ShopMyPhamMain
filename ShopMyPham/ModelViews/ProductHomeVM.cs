using System;
using System.Collections.Generic;
using ShopMyPham.Models;

namespace ShopMyPham.ModelViews
{
    public class ProductHomeVM
    {
        public Category ? category { get; set; }
        public List<Product> ? lsProducts { get; set; }
    }
}
