using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySchool.Models;

namespace MySchool.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Create new Level objects from the Level model
            ClassLevel intro = new ClassLevel() { Id = 1, Lable = "Introduction" };
            ClassLevel intermed = new ClassLevel() { Id = 1, Lable = "Intermediate" };
            ClassLevel advance = new ClassLevel() { Id = 1, Lable = "Advanced" };


            // Create new Student objects from the Student model
            Student fred = new Student() { Id = 1, Name = "Fred", ClassLevel = intro };
            Student john = new Student() { Id = 2, Name = "John", ClassLevel = advance };
            Student pete = new Student() { Id = 3, Name = "Pete", ClassLevel = intermed };
            Student mary = new Student() { Id = 4, Name = "Mary", ClassLevel = intro };


            // Create a new List of Student model type
            List<Student> studentList = new List<Student>();
            // Add the new student objects to the List
            studentList.Add(fred);
            studentList.Add(john);
            studentList.Add(pete);
            studentList.Add(mary);

            AcedemicClass physics = new AcedemicClass()
            {
                Id = 1,
                Name = "Physics",
                Students = studentList,
            };

            Grade fredPhy = new Grade() { Id = 1, StudentId = 1, AcedemicClass = physics, Numeric = 85 };

            //!!NOTE: un-comment one at a time
            // Order Examples
            //var filtered_list = studentList.OrderByDescending(s => s.Name);
            //var filtered_list = studentList.OrderByDescending(s => s.Level.Lable);

            // Testing, filter to show only intro
            var filtered_list = studentList.Select(s => s).Where(s => s.ClassLevel == intro);

            return View(filtered_list);
        }
    }
}