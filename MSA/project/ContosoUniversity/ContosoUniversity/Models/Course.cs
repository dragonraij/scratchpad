using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Department
    {
        SchoolofContosso, SchoolofScience, SchoolofHumanities
    }

    public enum Level
    {
        Undergrad, Postgrad
    }

    public enum AssessmentType
    {
        TestA, TestB, AssignmentA, AssignmentB, Research
    }

    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RegularExpression(@"^[A-Z]{2}[0-9]{3}$",
        ErrorMessage = "Course ID must be in the format XXnnn eg CS101"),
        Required(AllowEmptyStrings = false, ErrorMessage = "Course ID is required")]

        public int PaperID { get; set; }
        [StringLength(30,
        ErrorMessage = "Title must be less than 30 characters")]
        public string Title { get; set; }
        public string Description { get; set; }
        public Department Department { get; set; }
        public Level Level { get; set; }
        public AssessmentType AssessmentType { get; set; }

        [RegularExpression(@"(?:([^:/?#]+):)?(?://([^/?#]*))?([^?#]*\.(?:jp?g|gif|png))(?:\?([^#]*))?(?:#(.*))?", ErrorMessage = "Enter a url to a picture")]
        public string CoursePic { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual Lecturer Lecturer { get; set; }
    }
}