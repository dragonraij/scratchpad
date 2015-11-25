using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string About { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}