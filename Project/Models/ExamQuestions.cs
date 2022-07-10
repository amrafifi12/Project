using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ExamQuestions
    {
        [Key][Column(Order =0)]
        //[ForeignKey("QP")]
        public int QuestionID { set; get; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("exams")]
        public int ExamID { set; get; }
        // public virtual QuestionPool QP { get; set; }
        public virtual Exam exams { get; set; }

    }
}
