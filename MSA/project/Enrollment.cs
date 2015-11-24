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
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int PaperSemester {get; set;}

        public Grade? Grade { get; set; }
        public Status Status {get; set;}

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual PaperSemester PaperSemester {get; set;}
    }
}