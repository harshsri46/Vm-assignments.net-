
using System.ComponentModel.DataAnnotations;

namespace MVCforms.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please provide First Name")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please provide Last Name")]
        public string LastName { get; set; }

        [Range(0, 100, ErrorMessage = "Required and between 0 to 100")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Provide EmailId")]
        [EmailAddress(ErrorMessage = "Email id must be valid")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }

        public string Country { get; set; }
    }
}
