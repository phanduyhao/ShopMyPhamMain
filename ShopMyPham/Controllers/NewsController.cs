using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ShopMyPham.Models;

namespace ShopMyPham.Controllers
{
    public class NewsController : Controller
    {
        private readonly ShopMyPhamContext _context;
        public NewsController(ShopMyPhamContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var Pagesize = 10;
            var IsNews = _context.News.AsNoTracking().OrderByDescending(x => x.PostId);
            PagedList<News> models = new PagedList<News>(IsNews, pageNumber, Pagesize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        public IActionResult Details(int id)
        {
            var news = _context.News.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (news == null)
            {
                return RedirectToAction("Index");
            }

            return View(news);
        }
    }
}
