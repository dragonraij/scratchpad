using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{

    public class Lecturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LecturerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public short? Extension { get; set; }
        public string Bio { get; set; }

        //add link to profile pictures

        public virtual ICollection<PaperSemester> PaperSemesters { get; set; }
    }
}