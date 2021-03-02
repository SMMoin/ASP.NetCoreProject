using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetCoreProject_Moin.Data;
using ASPDotNetCoreProject_Moin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static ASPDotNetCoreProject_Moin.Helper;

namespace ASPDotNetCoreProject_Moin.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.BooksInfos.ToListAsync());
        }
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new BooksInfo());
            else
            {
                var bookModel = await _context.BooksInfos.FindAsync(id);
                if (bookModel == null)
                {
                    return NotFound();
                }
                return View(bookModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("BookId,AuthorNumber,BookName,AuthorName,ISBCode,Price,PublishingDate")] BooksInfo bookModel) 
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    //bookModel.PublishingDate = DateTime.Now;
                    _context.Add(bookModel);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    try
                    {
                        _context.Update(bookModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!BookModelExists(bookModel.BookId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.BooksInfos.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", bookModel) });
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.BooksInfos.FirstOrDefaultAsync(m => m.BookId == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookModel = await _context.BooksInfos.FindAsync(id);
            _context.BooksInfos.Remove(bookModel);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.BooksInfos.ToList()) });
        }

        private bool BookModelExists(int id) 
        {
            return _context.BooksInfos.Any(e => e.BookId == id);
        }
    }
}
