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

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Meow! Something's not right here. Please enter your first name using 30 characters or less.")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Meow! Something's not right here. Please enter your last name using 30 characters or less.")]
        public string? LastName { get; set; }

        [Display(Name = "Gender")]
        public Gender? GenderIdentity { get; set; }
        [StringLength(50, ErrorMessage = "Meow! Something's not right here. Please enter your address using 50 characters or less.")]
        public string? Address { get; set; }

        [StringLength(30, ErrorMessage = "Meow! Something's not right here. Please enter the city using 30 characters or less.")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Meow! Something's not right here. Please enter the state abbreviation using 2 characters.")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Meow! Something's not right here. Zipcode must be 10 numbers or less.")]
        public string? Zip { get; set; }
        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        public string? Cell { get; set; }
    }
}
