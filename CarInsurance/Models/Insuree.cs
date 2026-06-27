using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    // The Insuree class represents the database table storing user details and their generated quote
    public class Insuree
    {
        // Primary key for the database table
        public int Id { get; set; }

        // Customer's first name
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        // Customer's last name
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        // Customer's email address
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; } = string.Empty;

        // Customer's date of birth (used to calculate age additions)
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        // The year of the car being insured
        [Required]
        [Display(Name = "Car Year")]
        public int CarYear { get; set; }

        // The manufacturer/make of the car (e.g. Porsche)
        [Required]
        [Display(Name = "Car Make")]
        public string CarMake { get; set; } = string.Empty;

        // The model of the car (e.g. 911 Carrera)
        [Required]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; } = string.Empty;

        // Flag indicating if the customer has a history of DUI
        public bool DUI { get; set; }

        // Number of speeding tickets the customer has accumulated
        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a valid number of tickets.")]
        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }

        // The level of coverage requested (e.g. Full or Liability)
        [Required]
        [Display(Name = "Coverage Type")]
        public string CoverageType { get; set; } = string.Empty;

        // The final calculated monthly insurance premium/quote
        [Display(Name = "Monthly Quote")]
        public decimal Quote { get; set; }
    }
}
