﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopMyPham.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SearchController1 : Controller
    {
        private readonly ShopMyPhamContext _context;
        public SearchController1(ShopMyPhamContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> Is = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            Is = _context.Products
                                    .AsNoTracking()
                                    .Include(a => a.Cate)
                                    .Where(x => x.ProductName.Contains(keyword))
                                    .OrderByDescending(x => x.ProductName)
                                    .Take(10)
                                    .ToList();
            if (Is == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", Is);

            }
        }
    }
   
}
