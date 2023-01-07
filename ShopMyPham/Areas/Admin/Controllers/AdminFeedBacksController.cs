using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ShopMyPham.Helpper;
using ShopMyPham.Models;

namespace ShopMyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminFeedBacksController : Controller
    {
        private readonly ShopMyPhamContext _context;

        public AdminFeedBacksController(ShopMyPhamContext context)
        {
            _context = context;
        }

        // GET: Admin/FeedBacks
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var Pagesize = 20;
            var IsNews = _context.FeedBacks.AsNoTracking().OrderByDescending(x => x.IdFeedBack);
            PagedList<FeedBack> models = new PagedList<FeedBack>(IsNews, pageNumber, Pagesize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: Admin/FeedBacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FeedBacks == null)
            {
                return NotFound();
            }

            var feedBack = await _context.FeedBacks
                .FirstOrDefaultAsync(m => m.IdFeedBack == id);
            if (feedBack == null)
            {
                return NotFound();
            }

            return View(feedBack);
        }

        // GET: Admin/FeedBacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FeedBacks == null)
            {
                return NotFound();
            }

            var feedBack = await _context.FeedBacks
                .FirstOrDefaultAsync(m => m.IdFeedBack == id);
            if (feedBack == null)
            {
                return NotFound();
            }

            return View(feedBack);
        }

        // POST: Admin/FeedBacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FeedBacks == null)
            {
                return Problem("Entity set 'ShopMyPhamContext.FeedBacks'  is null.");
            }
            var feedBack = await _context.FeedBacks.FindAsync(id);
            if (feedBack != null)
            {
                _context.FeedBacks.Remove(feedBack);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedBackExists(int id)
        {
          return _context.FeedBacks.Any(e => e.IdFeedBack == id);
        }
    }
}
