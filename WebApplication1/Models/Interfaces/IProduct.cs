namespace WebApplication1.Models.Interfaces
{
    public interface IProduct
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
    }
}
