using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelExample
{
    internal class Course
    {
        public int No { get; set; }
        public String CourseNumber { get; set; }
        public String CourseName { get; set; }

        public Course (int No,String CourseNumber, String CourseName) {
            this.No = No;
            this.CourseNumber = CourseNumber;
            this.CourseName = CourseName;
        }
    }
}
