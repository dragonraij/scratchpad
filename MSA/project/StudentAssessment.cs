using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class StudentAssessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentAssessmentID { get; set; }
        public int EnrollmentID {get; set;}
        public DateTime? SubmissionTime{get; set;}
        public decimal? Marks{get; set;}
        public string? SubmissionLink{get; set;}
       
        public virtual ICollection<PaperSemester>  { get; set; }
    }
}