using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageWeb.Services.ProductService;
using RazorPageWeb.Models;
namespace RazorPageWeb.Pages.Products
{
    public class _ProductPageModel : PageModel
    {
        public List<Product> products { get; set; } = new List<Product>();

        public Product product;
        ProductService _productService;

        public _ProductPageModel(ProductService productService)
        {
            products = productService.GetProducts();
            _productService = productService;
        }

        public void OnGet(int? id, string? searchQuery)
        {
            if (id != null)
            {
                ViewData["Title"] = $"Thông tin sản phẩm (ID={id.Value})";
                product = _productService.GetProductsByID(id.Value);
                return;
            }

            if (!string.IsNullOrEmpty(searchQuery))
            {
                ViewData["Title"] = "Kết quả tìm kiếm";
                products = _productService.GetProducts()
                    .Where(p => p.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                return;
            }

            ViewData["Title"] = $"Danh sách sản phẩm";

        }

        public IActionResult OnGetLastProduct()
        {
            return (product = _productService.GetProducts().LastOrDefault()) != null ? Page() : NotFound();
        }

        //public IActionResult OnPostAdd(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productService.AddProduct(product);
        //        return RedirectToPage("ProductPage");
        //    }
        //    return Page();
        //}

        public IActionResult OnGetRemoveAllProduct()
        {
            //_productService.RemoveAll();
            //return RedirectToPage("ProductPage");
            products.Clear();
            return RedirectToPage("ProductPage");
        }

    }
}
