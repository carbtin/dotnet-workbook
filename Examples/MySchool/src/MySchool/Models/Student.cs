using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySchool.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int LevelId { get; set; }

        [Display(Name = "Class Level")]
        public virtual ClassLevel ClassLevel { get; set; }

        public virtual ICollection<Grade> Grade { get; set; }
    }
}
