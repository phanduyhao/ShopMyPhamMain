using Microsoft.AspNetCore.Mvc;

namespace ShopMyPham.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
    }
}
