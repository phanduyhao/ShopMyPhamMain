using System;
using System.Collections.Generic;
using ShopMyPham.Models;

namespace ShopMyPham.ModelViews
{
    public class HomeViewVM
    {
        public List<News> ? TinTucs { get; set; }
        public List<ProductHomeVM> ? Products { get; set; }
        public QuangCao ? quangcao { get; set; }
    }
}
