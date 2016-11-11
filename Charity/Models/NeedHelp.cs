using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Charity.Models
{
    public class NeedHelp
    {
        public int NeedHelpId { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "Please tell us your name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Please tell us your last name")]
        public string LastName { get; set; }

        /*
        [Required(ErrorMessage = "Please tell us your email")]
        [EmailAddress]
        public string Email { get; set; }
        */

        [Required(ErrorMessage = "Please tell us your phone number")]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Tell us about your problem")]
        public string Message { get; set; }
    }
}