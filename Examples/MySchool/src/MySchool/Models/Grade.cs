using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySchool.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public decimal? Numeric { get; set; }
        public string Label { get; set; }
        public int StudentId { get; set; }

        [Display(Name = "Class Grade")]
        public virtual AcedemicClass AcedemicClass { get; set; }

        public virtual Student Student { get; set; }

        public string LetterGrade
        {
            get {
                var gradeMap = new Dictionary<int, string>
                {
                    [0] = "F",
                    [60] = "D",
                    [70] = "C",
                    [80] = "B",
                    [90] = "A"
                };

                return gradeMap.OrderByDescending(x => x.Key).FirstOrDefault(x => x.Key <= Numeric).Value;
            }
        }
    }
}
