using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPDotNetCoreProject_Moin.Data;
using ASPDotNetCoreProject_Moin.Models;
using ASPDotNetCoreProject_Moin.ViewModels;

namespace ASPDotNetCoreProject_Moin.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IHostingEnvironment webHostEnvironment;
        public TeacherController(ApplicationDbContext context, IHostingEnvironment hostEnvironment)
        {
            db = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var teacher = from s in db.Teachers
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                teacher = teacher.Where(s => s.TeacherName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    teacher = teacher.OrderByDescending(s => s.TeacherName);
                    break;
                case "Date":
                    teacher = teacher.OrderBy(s => s.JoiningDate);
                    break;
                case "date_desc":
                    teacher = teacher.OrderByDescending(s => s.JoiningDate);
                    break;

            }

            int pageSize = 3;
            return View(await PaginatedList<Teacher>.CreateAsync(teacher.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        //public async Task<IActionResult> Index()
        //{
        //    return View(await db.Teachers.ToListAsync());
        //}

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await db.Teachers
                .FirstOrDefaultAsync(m => m.Id == id);

            var teacherViewModel = new TeacherViewModel()
            {
                Id = teacher.Id,
                TeacherName = teacher.TeacherName,
                Designation = teacher.Designation,
                Address = teacher.Address,
                ContactNo = teacher.ContactNo,
                Email = teacher.Email,
                JoiningDate = teacher.JoiningDate,
                ExistingImage = teacher.ProfilePicture
            };

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                Teacher teacher = new Teacher
                {
                    TeacherName = model.TeacherName,
                    Designation = model.Designation,
                    Address = model.Address,
                    ContactNo = model.ContactNo,
                    Email = model.Email,
                    JoiningDate = model.JoiningDate,
                    ProfilePicture = uniqueFileName
                };

                db.Add(teacher);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await db.Teachers.FindAsync(id);
            var teacherViewModel = new TeacherViewModel()
            {
                Id = teacher.Id,
                TeacherName = teacher.TeacherName,
                Designation = teacher.Designation,
                Address = teacher.Address,
                ContactNo = teacher.ContactNo,
                Email = teacher.Email,
                JoiningDate = teacher.JoiningDate,
                ExistingImage = teacher.ProfilePicture
            };

            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacherViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                var teacher = await db.Teachers.FindAsync(model.Id);
                teacher.TeacherName = model.TeacherName;
                teacher.Designation = model.Designation;
                teacher.Address = model.Address;
                teacher.ContactNo = model.ContactNo;
                teacher.Email = model.Email;
                teacher.JoiningDate = model.JoiningDate;

                if (model.TeacherPicture != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads", model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    teacher.ProfilePicture = ProcessUploadedFile(model);
                }
                db.Update(teacher);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await db.Teachers
                .FirstOrDefaultAsync(m => m.Id == id);

            var teacherViewModel = new TeacherViewModel() 
            {
                Id = employee.Id,
                TeacherName = employee.TeacherName,
                Designation = employee.Designation,
                Address = employee.Address,
                ContactNo = employee.ContactNo,
                Email = employee.Email,
                JoiningDate = employee.JoiningDate,
                ExistingImage = employee.ProfilePicture
            };
            if (employee == null)
            {
                return NotFound();
            }

            return View(teacherViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auther = await db.Teachers.FindAsync(id);
            var CurrentImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", auther.ProfilePicture);
            db.Teachers.Remove(auther);
            if (await db.SaveChangesAsync() > 0)
            {
                if (System.IO.File.Exists(CurrentImage))
                {
                    System.IO.File.Delete(CurrentImage);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerExists(int id)
        {
            return db.Teachers.Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(TeacherViewModel model)
        {
            string uniqueFileName = null;

            if (model.TeacherPicture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.TeacherPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.TeacherPicture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
