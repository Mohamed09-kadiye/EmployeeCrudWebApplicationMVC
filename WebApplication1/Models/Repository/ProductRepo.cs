using WebApplication1.Models.Interfaces;

namespace WebApplication1.Models.Repository
{
    public class ProductRepo : IProduct
    {
        List<Product> products = new List<Product>()
        {
            new Product { Id = 1,Name="Safiyo",Tell="25261577796",Adress="dayniile",username="maima12",password="12334a",Title="manager"},
            new Product { Id = 3,Name="Hassen",Tell="25261577796",Adress="cadakibir",username="hasse1",password="346553",Title="Cashier"},

        };

        public List<Product> GetAllProducts()
        {
            return products.ToList();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
