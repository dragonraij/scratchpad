using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class StudentAssessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentAssessmentID { get; set; }
        public DateTime? SubmissionTime { get; set; }
        public decimal? Marks { get; set; }
        public string SubmissionLink { get; set; }

        public virtual Enrollment Enrollment { get; set; }
}
}