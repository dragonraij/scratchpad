using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RajContoso.Models
{
    public class StudentAssessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentAssessmentID { get; set; }
       
        [Display(Name = "Submission Time")]
        public DateTime? SubmissionTime { get; set; }
        public float? Marks { get; set; }

        [RegularExpression(@"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,4}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)",
        ErrorMessage = "Enter valid web address")]
        [Display(Name = "Submission Link")]
        public string SubmissionLink { get; set; }

        //reference foreign key
        public int EnrollmentID { get; set; }
        public virtual Enrollment Enrollment { get; set; }
    }
}