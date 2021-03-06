using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
		public enum Department {
			SchoolofContosso, SchoolofScience, SchoolofHumanities
		}

		public enum Level {
			Undergrad, Postgrad
		}

		public enum AssessmentType{
			TestA, TestB, AssignmentA, AssignmentB, Research
		}

    public class Paper
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaperID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Department Department{ get; set;}
        public Level Level {get; set;}
        public AssessmentType AssessmentType{get; set;}
        //course image

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}