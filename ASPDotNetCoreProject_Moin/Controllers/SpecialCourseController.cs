using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetCoreProject_Moin.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreProject_Moin.Controllers
{
    public class SpecialCourseController : Controller
    {
        private ISpecialCourseRepository db;

        public SpecialCourseController(ISpecialCourseRepository db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.GetAll());
        }



        // GET:Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SpecialCourse course)
        {

            db.Add(course);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(db.GetCourse(id));
        }

        [HttpPost]
        public IActionResult Edit(SpecialCourse course)
        {
            db.Update(course);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.GetCourse(id));
        }
    }
}