using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySchool.Models
{
    public class AcedemicClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public string Bldg { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Grade> Grade { get; set; }
    }
}
