using System;
using System.ComponentModel.DataAnnotations;

namespace ShopMyPham.ModelViews
{
    public class LoginViewModel
    {
        [Key]

        public string Email { get; set; }
        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
