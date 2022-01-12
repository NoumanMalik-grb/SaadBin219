using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaadBin219.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public String CourseName { get; set; }
        public String CourseCode { get; set; }
    }
}
