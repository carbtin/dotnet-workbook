using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string fName { get; set; }
        [Display(Name = "Last Name")]
        public string lName { get; set; }
        [Display(Name = "Course Enrollment")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

    }
}
