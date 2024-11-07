using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageWeb.Models;
using RazorPageWeb.Services.ProductService;

namespace RazorPageWeb.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ProductService _productService;

        public CreateModel(ProductService service)
        {
            _productService = service;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPostAdd(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return RedirectToPage("ProductPage");
            }
            return Page();
        }
    }
}
