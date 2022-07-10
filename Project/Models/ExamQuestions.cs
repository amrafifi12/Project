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
        public int QuestID { set; get; }

        [Key][Column(Order = 1)][ForeignKey("Exam")]
        public int ExamID { set; get; }
        public virtual Exam Exam { set; get; }
    }
}
