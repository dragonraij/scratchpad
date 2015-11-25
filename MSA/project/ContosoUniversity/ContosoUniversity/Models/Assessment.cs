using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum SubmissionType {
        Test, Exam, Assignment, Report, Presentation, Research
    }
    public class Assessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssessmentID { get; set; }
        public SubmissionType SubmissionType { get; set; }

        public int TotalMarks { get; set; }
        public decimal Weight { get; set; }
        public DateTime DueDate { get; set; }


    public virtual ICollection<PaperSemester> PaperSemesters { get; set; }
    }
}