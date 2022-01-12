using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaadBin219.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public String TeacherName { get; set; }
        public String TeacherEmail { get; set; }
        public String TeachertPhone { get; set; }
        public String  Department { get; set; }
    }
}
