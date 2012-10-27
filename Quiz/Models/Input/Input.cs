using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models.Input
{
    public class EmployeeInput
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string[] role { get; set; }
        public string bio { get; set; }
        public string branch { get; set; }
    }

    public class Parent
    {
        public EmployeeInput[] employees { get; set; }
    }


}