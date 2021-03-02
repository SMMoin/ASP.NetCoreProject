using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ASPDotNetCoreProject_Moin.Repositories;
using Microsoft.AspNetCore.Hosting;
using ASPDotNetCoreProject_Moin.Models;
using System.IO;

namespace ASPDotNetCoreProject_Moin.Controllers
{
    public class StudentController : Controller
    {
        private IStudent _db;
        private readonly IHostingEnvironment _environment;

        public StudentController(IStudent db, IHostingEnvironment environment)
        {
            this._db = db;
            this._environment = environment;
        }

        public IActionResult Index()
        {
            return View(_db.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                string ImageUrl = "";

                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;

                        var upload = Path.Combine(_environment.WebRootPath, "images");

                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + file.FileName;

                            using (var fileStream = new FileStream(Path.Combine(upload, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                ImageUrl = fileName;
                            }
                        }
                    }
                }

                var data = new Student()
                {
                    Name = student.Name,
                    Address = student.Address,
                    UrlImage = student.UrlImage,
                    CellPhone = student.CellPhone,
                    Email = student.Email
                };

                _db.Add(data);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {

            return View(_db.GetStudent(id));
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {

            _db.Update(student);
            return RedirectToAction("Index");
        }
    }
}