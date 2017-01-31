using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySchool.Models
{
    public class ClassLevel
    {
        public int Id { get; set; }
        [Display(Name = "Class Level")]
        public string Lable { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
