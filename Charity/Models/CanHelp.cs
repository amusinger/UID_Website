using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Charity.Models
{
    public class CanHelp
    {
        public int CanHelpId { get; set; }

        [Display(Name="First name")]
      //  [Required(ErrorMessage = "Please tell us your name")]
        public string FirstName { get; set; }

        [Display(Name="Last name")]
      //  [Required(ErrorMessage = "Please tell us your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage="Please tell us your email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name="Credit card number")]
        [Required(ErrorMessage = "Please enter your credit card number")]
        [CreditCard]
        public string CreditCard { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage="Please enter CV number")]
        [Display(Name="CV number on your credit card (Security code)")]
        public int CV { get; set; }

        [Required]
        public int Amount { get; set; }
}
}