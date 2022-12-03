using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopMyPham.Models;

namespace ShopMyPham.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopMyPhamContext _context;
        public ProductController(ShopMyPhamContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var product = _context.Products.Include(x => x.Cate).FirstOrDefault(x => x.ProductId == id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
