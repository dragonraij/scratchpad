using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Type
    {
        Report, Research, Presentation, Assignment, Other
    }

    public class Assessment
    {
        [Display(Name = "")]
        public int AssessmentID { get; set; }
        public int EnrollmentID { get; set; }
        [Display(Name = "Submitted On")]
        public string SubmissionTime { get; set; }
        [Display(Name = "Submission Link")]
        [RegularExpression("^(https?:\\/\\/)?([\\da-z\\.-]+)\\.([a-z\\.]{2,6})([\\/\\w \\.-]*)*\\/?$")]
        public string SubmissionLink { get; set; }
        public decimal? Marks { get; set; }

        [JsonIgnore]
        public virtual Enrollment Enrollment { get; set; }
        


    }
}