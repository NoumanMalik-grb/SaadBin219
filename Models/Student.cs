using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaadBin219.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public String StudentName { get; set; }
        public String StudentEmail { get; set; }
        public String Section { get; set; }
    }
}
