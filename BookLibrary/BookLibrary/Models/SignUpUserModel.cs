using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage ="Please enter your First Name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "First Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter your Email!")]
        [Display(Name ="Email address")]
        [EmailAddress(ErrorMessage ="Please enter a valid Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Password!")]
        [Compare("ConfirmPassword", ErrorMessage ="Password does not match!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your Confirm Password!")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
