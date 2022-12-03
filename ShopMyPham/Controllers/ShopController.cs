using Microsoft.AspNetCore.Mvc;

namespace ShopMyPham.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }

        public IActionResult ShopProduct()
        {
            return View();
        }
        public IActionResult Nuoc_Hoa_Nam()
        {
            return View();
        }
        public IActionResult Nuoc_Hoa_Nu()
        {
            return View();
        }
        public IActionResult Huong_Trai_Cay()
        {
            return View();
        }
        public IActionResult Huong_Bien()
        {
            return View();
        }
        public IActionResult Cham_Soc_Da()
        {
            return View();
        }
        public IActionResult Dau_Thom()
        {
            return View();
        }
        public IActionResult Kem_Chong_Nang()
        {
            return View();
        }
        public IActionResult Dau_Goi()
        {
            return View();
        }
            public IActionResult Dau_Xa()
        {
            return View();
        }
        public IActionResult Son_Duong()
        {
            return View();
        }
        public IActionResult Son_Chi()
        {
            return View();
        }
    }
}
