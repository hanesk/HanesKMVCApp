using System;
using System.ComponentModel.DataAnnotations;

namespace HanesKMVCApp.Models
{
    public enum Gender
    {
        Male,
        Female,
        Nonbinary,
        Other
    }
    public class Members
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Meow! First name is required")]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Meow! Something's not right here. Please enter your first name using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Meow! Only alphabetic letters are allowed.")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Meow! Something's not right here. Please enter your last name using 30 characters or less.")]
        public string? LastName { get; set; }

        [Display(Name = "Gender")]
        public Gender? GenderIdentity { get; set; }
        [StringLength(50, ErrorMessage = "Meow! Something's not right here. Please enter your address using 50 characters or less.")]

        [Display(Name = "Address")]
        public string? Address { get; set; }

        [StringLength(30, ErrorMessage = "Meow! Something's not right here. Please enter the city using 30 characters or less.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Meow! Only alphabetic letters are allowed.")]
        [Display(Name = "City")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Meow! Something's not right here. Please enter the state abbreviation using 2 characters.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Meow! Only alphabetic letters are allowed.")]
        [Display(Name = "State")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Meow! Something's not right here. Zipcode must be 10 numbers or less.")]
        [Display(Name = "Zipcode")]
        public string? Zip { get; set; }

        [Required(ErrorMessage = "Meow! Email is required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Meow! Incorrect Email Format")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        public string? Cell { get; set; }
    }
}
