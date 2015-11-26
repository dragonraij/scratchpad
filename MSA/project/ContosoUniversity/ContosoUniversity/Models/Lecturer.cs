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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LecturerID { get; set; }

        [Required(
        AllowEmptyStrings = false,
        ErrorMessage = "Last name can't be empty")]
        public string LastName { get; set; }

        [Required(
        AllowEmptyStrings = false,
        ErrorMessage = "First name can't be empty")]
        public string FirstName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }

        [Range(1, 999, ErrorMessage = "Extention has to be between 0 and 999")]
        public short? Extension { get; set; }
        public string Bio { get; set; }

        [RegularExpression(@"(?:([^:/?#]+):)?(?://([^/?#]*))?([^?#]*\.(?:jp?g|gif|png))(?:\?([^#]*))?(?:#(.*))?", ErrorMessage = "Enter a url to a picture")]
        public string ProfilePic { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}