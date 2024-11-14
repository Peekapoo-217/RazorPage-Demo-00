using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RazorPageWeb.Validators;

namespace RazorPageWeb.Models
{
    [BindProperties]
    public class Contact
    {
        [Range(1, 100, ErrorMessage = "Invalid input")]
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [CustomBirthDate(ErrorMessage = "Date of birth must be less than current date")]
        public DateTime DateofBirth { get; set; }
    }
}
