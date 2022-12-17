using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ShopMyPham.Models;
namespace ShopMyPham.Controllers
{
    public class AboutController : Controller
    {

        private readonly ILogger<AboutController> _logger;
        private readonly ShopMyPhamContext _context;

        public AboutController(ILogger<AboutController> logger, ShopMyPhamContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("gioi-thieu.html", Name = ("AboutUs"))]
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("lien-he.html", Name = ("Contact"))]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
