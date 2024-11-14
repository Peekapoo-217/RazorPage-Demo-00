using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RazorPageWeb.Models
{
    public class Product
    {
        [BindProperty]
        [Range(1, 100, ErrorMessage = "The value must be between 1 and 100")]
        [Required]
        public int Id { get; set; }

        [BindProperty]
        [Required]
        public string? Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price { get; set; } = 0;
    }
}
