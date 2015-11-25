﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{

    public enum Semester
    {
        Semester1, Semester2, Summer
    }

    public class PaperSemester
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaperSemesterID { get; set; }
        public DateTime Year { get; set; }
        public Semester Semester { get; set; }
        public Paper Paper { get; set; }


        public virtual Lecturer Lecturer { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}