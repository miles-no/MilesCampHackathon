using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string[] Role { get; set; }
        public string Biography { get; set; }
        public string Branch { get; set; }
    }
}