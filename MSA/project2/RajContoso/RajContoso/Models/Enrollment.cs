using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RajContoso.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public enum Status
    {
        Enrolled, Dropped, Completed
    }

    public class Enrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
        [Required]
        public Status Status { get; set; }

        public string CourseID { get; set; }
        public int StudentID { get; set; }

        public virtual ICollection<StudentAssessment> StudentAssessments { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}