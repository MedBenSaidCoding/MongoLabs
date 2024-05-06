
namespace SampleParis.Infrastructure.Products
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);

        Task<List<Product>> GetAllProductsAsync();
    }
}