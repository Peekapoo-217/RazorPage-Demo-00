using Microsoft.AspNetCore.Mvc;
using RazorPageWeb.Models;
using RazorPageWeb.Services.ProductService;

namespace RazorPageWeb.Pages.Shared.Components.ProductBox
{

    public class ProductBoxComponent : ViewComponent
    {
        //List<Product> listProducts = new List<Product>()
        //{
        //    new Product() { Name = "Xiaomi", Description = "Ngầu", Price = 2000000 },
        //    new Product() { Name = "Xiaomi", Description = "Ngầu", Price = 2000000 },
        //    new Product() { Name = "Xiaomi", Description = "Ngầu", Price = 2000000 }
        //};

        List<Product> listProducts = null;

        public ProductBoxComponent(ProductService service)
        {
            listProducts = service.GetProducts();
        }



        public IViewComponentResult Invoke()
        {
            return View(listProducts);
        }

    }
}
