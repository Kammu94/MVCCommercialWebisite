using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartMobilesStore.Models
{
    public class UserAccountModel
    {
        
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "This Field is Compulsory")]
        [RegularExpression("^([a-zA-Z .&'-]+)$", ErrorMessage = "Only Alphabets are valid")]
        [StringLength(40,MinimumLength =4,ErrorMessage ="Firstname must be between 3 and 40 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This Field is Compulsory")]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "Lastname must be between 3 and 40 characters")]
        [RegularExpression("^([a-zA-Z .&'-]+)$", ErrorMessage = "Only Alphabets are valid")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This Field is Compulsory")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Email Address Is not Valid")]
        public string Email { get; set; }

        [StringLength(20, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 40 characters")]
        [Required(ErrorMessage = "This Field is Compulsory")]
        public string Password { set; get; }

        [Required(ErrorMessage = "This Field is Compulsory")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Enter 10 digits only")]// @"^([0-9]{10})$"
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "This Field is Compulsory")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "This Field is Compulsory")]
        public string Country { get; set; }

        [Required(ErrorMessage = "This Field is Compulsory")]
        [Compare("Password",ErrorMessage ="Password must match")]
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }

        public bool? isValid { get; set; }

    }
}