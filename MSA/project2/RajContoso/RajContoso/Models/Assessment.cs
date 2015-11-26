using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RajContoso.Models
{
    public enum SubmissionType
    {
        Test, Exam, Assignment, Report, Presentation, Research, Other
    }
    public class Assessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssessmentID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Submission Type must be selected")]
        public SubmissionType SubmissionType { get; set; }

        public float TotalMarks { get; set; }

        [Range(0, 1, ErrorMessage = "Weight has to be between 0 and 1")]
        public float Weight { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        public string CourseID { get; set; }

        public virtual Course Course { get; set; }
    }
}