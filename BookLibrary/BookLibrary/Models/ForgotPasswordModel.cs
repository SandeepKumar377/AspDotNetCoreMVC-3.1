using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class ForgotPasswordModel
    {
        [Required, EmailAddress, Display(Name ="Register email address")]
        public string Email { get; set; }

        public bool EmailSend { get; set; }
    }
}
