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
        public int EnrollmentID { get; set; }
   //     public int StudentAssessmentID { get; set; }
        public int StudentID { get; set; }
        public int PaperSemesterID { get; set; }

        public Grade? Grade { get; set; }
        public Status Status { get; set; }

    //    public virtual StudentAssessment StudentAssessment { get; set; }
        public virtual Student Student { get; set; }
        public virtual PaperSemester PaperSemester { get; set; }
    }
}