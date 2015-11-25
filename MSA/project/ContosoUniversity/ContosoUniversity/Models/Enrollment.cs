using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
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
       // public int StudentAssessmentID { get; set; }
      //  public int StudentID { get; set; }
        

        public Grade? Grade { get; set; }
        public Status Status { get; set; }

        //foreign Keys
        [ForeignKey("PaperSemester"), Column(Order = 0)]
        public DateTime Year { get; set; }
        [ForeignKey("PaperSemester"), Column(Order = 1)]
        public Semester Semester { get; set; }
        [ForeignKey("PaperSemester"), Column(Order = 2)]
        public Paper Paper { get; set; }


        public virtual ICollection<StudentAssessment> StudentAssessments { get; set; }
        public virtual Student Student { get; set; }
        public virtual PaperSemester PaperSemester { get; set; }
    }
}