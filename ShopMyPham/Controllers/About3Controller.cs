﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ShopMyPham.Helpper;
using ShopMyPham.Models;

namespace ShopMyPham.Controllers
{
    public class About3Controller : Controller
    {
        private readonly ShopMyPhamContext _context;

        public About3Controller(ShopMyPhamContext context)
        {
            _context = context;
        }

        [Route("gioi-thieu.html", Name = ("AboutUs"))]
        public IActionResult AboutUs()
        {
            return View();
        }
        // GET: About3/Create
        [Route("lien-he.html", Name = ("Contact"))]

        public IActionResult Contact()
        {
            return View();
        }

        // POST: About3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("lien-he.html", Name = ("Contact"))]

        public async Task<IActionResult> Contact([Bind("IdFeedBack,Fullname,Email,ContentFeed")] FeedBack feedBack)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedBack);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Contact));
            }
            return View(feedBack);
        }


        private bool FeedBackExists(int id)
        {
          return _context.FeedBacks.Any(e => e.IdFeedBack == id);
        }
    }
}
