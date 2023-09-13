using System.ComponentModel.DataAnnotations;

namespace UmbracoProject1.Models
{
    public class RequestModel
    {
        [Display(Name = "Name", Description = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your name")]
        [MaxLength(100, ErrorMessage = "Should not exceed 100 characters")]
        public string Names { get; set; }

        [Display(Name ="Last Name", Description = "Last Name")]
        [Required(AllowEmptyStrings =false, ErrorMessage = "Enter your last name")]
        [DataType(DataType.Text, ErrorMessage = "Enter your last name")]
        [MaxLength(100, ErrorMessage = "Should not exceed 100 characters")]
        public string LastName { get; set; }

        [Display(Name = "Business", Description = "Business")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your business")]
        [DataType(DataType.Text, ErrorMessage = "Enter your business")]
        [MaxLength(100, ErrorMessage = "Should not exceed 100 characters")]
        public string Company { get; set; }

        [Display(Name = "Position", Description = "Position")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your position")]
        [DataType(DataType.Text, ErrorMessage = "Enter your position")]
        [MaxLength(100, ErrorMessage = "Should not exceed 100 characters")]
        public string Position { get; set; }


        [Display(Name = "Email", Description = "Email")]
        [Required(ErrorMessage = "Enter your email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter your email")]
        public string Email { get; set; }

        [Display(Name = "Phone", Description = "Phone")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your phone number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Enter your phone number")]
        [MaxLength(20, ErrorMessage = "Should not exceed 20 characters")]
        public string Phone { get; set; }

        [Display(Name = "Message", Description = "Message")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your message")]
        [DataType(DataType.MultilineText, ErrorMessage = "Enter your message")]
        [MaxLength(600, ErrorMessage = "Should not exceed 600 characters")]
        public string Message { get; set; }
    }
}

