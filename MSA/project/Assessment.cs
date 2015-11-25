using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Assessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssessmentID { get; set; }
        public int PaperSemesterID {get; set;}

        public Type { get; set; }
        
        public int TotalMarks { get; set; }
        public decimal Weight {get; set;}
        public DateTime DueDate{get; set;}

       
        public virtual ICollection<PaperSemester>  { get; set; }
    }
}