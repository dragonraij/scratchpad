using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RajContoso.Models
{

    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Required, MaxLength(40, ErrorMessage = "Name is too long, please use less than 40 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, MaxLength(40, ErrorMessage = "Name is too long, please use less than 40 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string About { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}