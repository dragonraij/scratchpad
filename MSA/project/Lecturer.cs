using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{

    public class Lecturer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public short Extension {get; set;}
        public string Bio {get; set;}

        //add link to profile pictures
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}