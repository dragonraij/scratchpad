using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{

    public enum Semester
    {
        Semester1, Semester2, Summer
    }

    public class PaperSemester
    {
        [Key, Column(Order =0)]
        public DateTime Year { get; set; }

        [Key, Column(Order = 1)]
        public Semester Semester { get; set; }

        [Key, Column(Order = 2)]
        public Paper Paper { get; set; }


        public virtual Lecturer? Lecturer { get; set; }
        public virtual ICollection<Assessment> Assessments{get; set;}
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}