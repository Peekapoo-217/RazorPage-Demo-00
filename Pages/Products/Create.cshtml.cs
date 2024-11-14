using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageWeb.Models;
using RazorPageWeb.Services.ProductService;
using System.ComponentModel.DataAnnotations;

namespace RazorPageWeb.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ProductService _productService;

        private IWebHostEnvironment _environment;

        [BindProperty]
        public List<IFormFile> listOfImageProduct { get; set; } = default!; 

        [BindProperty]
        public Product Product
        {
            get; set;
        }

        [DataType(DataType.Upload)]
        //[FileExtensions(Extensions = "png,jpg,jpeg,gif")]
        [Display(Name = "File upload")]
        [BindProperty]
        public IFormFile FileUpLoad { get; set; } = default!;


        public CreateModel(ProductService service, IWebHostEnvironment environment)
        {
            _productService = service;
            _environment = environment;
        }

        public void OnGet() { }

        public async  Task<IActionResult> OnPostAdd(Product product)
        {
            if (true)
            {
                _productService.AddProduct(product);
                foreach(var item in listOfImageProduct)
                {
                    if (item != null)
                    {
                        var file = Path.Combine(_environment.WebRootPath, "uploads", item.FileName);
                        using (var filestream = new FileStream(file, FileMode.Create))
                        {
                            await item.CopyToAsync(filestream);
                        }
                    }
                }
                return RedirectToPage("ProductPage");
            }
            return Page();
        }


    }
}
