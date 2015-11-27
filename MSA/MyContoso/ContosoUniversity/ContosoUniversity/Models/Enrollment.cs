using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        [JsonIgnore]
        public virtual Course Course { get; set; }
        [JsonIgnore]
        public virtual Student Student { get; set; }
        [JsonIgnore]
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}