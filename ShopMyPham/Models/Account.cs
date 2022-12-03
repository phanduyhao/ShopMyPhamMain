﻿using System;
using System.Collections.Generic;

namespace ShopMyPham.Models
{
    public partial class Account
    {
        public Account()
        {
            News = new HashSet<News>();
        }

        public int AccountId { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? Salt { get; set; }
        public bool Active { get; set; }
        public string? FullName { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
