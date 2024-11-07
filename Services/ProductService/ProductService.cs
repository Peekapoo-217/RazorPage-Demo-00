using RazorPageWeb.Models;

namespace RazorPageWeb.Services.ProductService
{
    public class ProductService
    {
        List<Product> listProducts = new List<Product>()
        {
            new Product() { Id = 1, Name = "Xiaomi", Description = "Ngầu", Price = 2000000 },
            new Product() { Id = 2, Name = "Iphone", Description = "Nice", Price = 2000000 },
            new Product() { Id = 3,Name = "Red", Description = "Ngầu", Price = 2000000 }
        };

        public List<Product> GetProducts() { return listProducts; }

        public void AddProduct(Product product)
        {
            product.Id = listProducts.Any() ? listProducts.Max(p => p.Id) + 1 : 1;
            listProducts.Add(product);
        }

        public Product GetProductsByID(int id)
        {
            return listProducts.SingleOrDefault(p => p.Id == id);
        }

        public void RemoveAll()
        {
            listProducts.Clear();
        }
    }
}
