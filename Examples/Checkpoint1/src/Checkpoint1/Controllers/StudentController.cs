using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Checkpoint1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Checkpoint1.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationContext db_context;

        public StudentController(ApplicationContext context)
        {
            db_context = context;
        }

        // GET: /<controller>/
        public IActionResult Index(int? courseFilter = 0)
        {
            var crs = db_context.Course.OrderBy(c => c.Label).Select(c => new { id = c.Id, value = c.Label }).ToList();
            ViewBag.CourseSelectList = new SelectList(crs, "id", "value");

            IQueryable<Student> students;

            var s_all = db_context.Student.Include(a => a.Course);

            if(courseFilter > 0)
            {
                students = s_all.Where(s => s.CourseId == courseFilter);
            }
            else
            {
                // do nothing, all
                students = s_all.Select(s => s);
            }

            return View(students.ToList());
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            var crs = db_context.Course.OrderBy(c => c.Label).Select(c => new { id = c.Id, value = c.Label }).ToList();

            ViewBag.CourseSelectList = new SelectList(crs, "id", "value");

            return View();
        }

        // POST: Stuudent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if(!ModelState.IsValid)
            {
                var crs = db_context.Course.OrderBy(c => c.Label).Select(c => new { id = c.Id, value = c.Label }).ToList();
                ViewBag.CourseSelectList = new SelectList(crs, "id", "value");

                return View("Create", student);
            }

            db_context.Student.Add(student);
            db_context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db_context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
