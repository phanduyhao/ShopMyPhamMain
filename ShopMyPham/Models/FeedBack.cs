using System;
using System.Collections.Generic;

namespace ShopMyPham.Models
{
    public partial class FeedBack
    {
        public int IdFeedBack { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? ContentFeed { get; set; }
    }
}
