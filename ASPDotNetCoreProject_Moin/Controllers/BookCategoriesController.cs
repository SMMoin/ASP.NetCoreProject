using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPDotNetCoreProject_Moin.Data;
using ASPDotNetCoreProject_Moin.Models;

namespace ASPDotNetCoreProject_Moin.Controllers
{
    public class BookCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public readonly IHostingEnvironment _hostingEnvironment;

        public BookCategoriesController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<ActionResult> Index()
        {
            ViewBag.BookCatagoryID = new SelectList(_context.BookCategories, "ID", "Name");
            return View(await _context.BookCategories.ToListAsync());
        }
        public ActionResult GetCategoryWiseItems(long? id)
        {
            if (id == null)
            {
                NotFound();
            }

            ViewData["id"] = id;
            List<Books> books = _context.Books.Where(e => e.BookCategoryID == id).ToList();

            if (books == null)
            {
                NotFound();
            }

            return PartialView("CategoryWiseItems", books);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Books books, BookCategory category, IFormFile[] Image)
        {
            try
            { 

                if (Image != null)
                {
                    if (category.Books.Count == Image.Count())
                    {
                        for (int i = 0; i < category.Books.Count; i++)
                        {

                            string picture = System.IO.Path.GetFileName(Image[i].FileName);
                            var file = picture;
                            var uploadFile = Path.Combine(_hostingEnvironment.WebRootPath, "images", picture);

                            using (MemoryStream ms = new MemoryStream())
                            {
                                Image[i].CopyTo(ms);
                                category.Books[i].BookImage = ms.GetBuffer();
                            }
                        }
                    }
                    _context.BookCategories.Add(category);
                    _context.SaveChanges();
                    TempData["id"] = category.ID;
                    return RedirectToAction("Index");
                }

                return View(category);
            }
            catch (Exception)
            {
                return View(category);
            }
        }


        public IActionResult Delete(long id)
        {
            BookCategory category = _context.BookCategories.Find(id);
            if (category != null)
            {
                _context.BookCategories.Remove(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteItem(long id)
        {
            Books book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }
    }
}