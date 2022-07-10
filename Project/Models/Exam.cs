using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Exam
    {
        public int Id { set; get; }
        public int CourseID { set; get; }
        public int InstructorID { set; get; }
        public DateTime start { set; get; }
        public DateTime End { set; get; }
        public int Degree { set; get; }

    }
}
