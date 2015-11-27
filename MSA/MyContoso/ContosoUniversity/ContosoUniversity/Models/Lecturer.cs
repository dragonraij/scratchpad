using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Lecturer
    {
        public int ID { get; set; }

        [Display(Name = "Last Name"), StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Column("FirstName"), Display(Name = "First Name"), StringLength(50, MinimumLength = 1)]
        public string FirstMidName { get; set; }

        public string Bio { get; set; }
        public string Picture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        [JsonIgnore]
        public virtual ICollection<Course> Courses { get; set; }

    }
}