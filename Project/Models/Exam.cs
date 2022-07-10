using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Exam
    {
        public int Id { set; get; }

        //
        public int CourseId { set; get; }

        //
        public int InstructorId { set; get; }
        public DateTime Start { set; get; }
        public DateTime End { set; get; }
        public int degree { set; get; }
        public List<ExamQuestions> ExamQuestions { set; get; }

    }
}
