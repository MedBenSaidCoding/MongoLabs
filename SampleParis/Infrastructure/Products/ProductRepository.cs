using Microsoft.Extensions.Options;

namespace SampleParis.Infrastructure.Products
{
    public class ProductRepository:IProductRepository
    {
        private readonly IMongoCollection<Product> _productsCollection;

        public ProductRepository(IOptions<ParisStoreDbSettings> parisStoreDbSettings)
        {
            var mongoDbClient = new MongoClient(parisStoreDbSettings.Value.ConnectionString);
            var parisStoreDB = mongoDbClient.GetDatabase(parisStoreDbSettings.Value.DatabaseName);
            _productsCollection = parisStoreDB.GetCollection<Product>(parisStoreDbSettings.Value.ProductsCollectionName);
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
           return await _productsCollection.Find(_=>true).ToListAsync();
        }

        public async Task CreateProductAsync(Product product)
        {
            await _productsCollection.InsertOneAsync(product);
        }

        
    }
}