using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoStudentData.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Malayalam { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
    }
}