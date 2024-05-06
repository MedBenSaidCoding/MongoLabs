using Microsoft.AspNetCore.Mvc;
using SampleParis.Infrastructure.Products;

namespace SampleParis.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ProductsController:ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository?? 
                throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
           var products = await _productRepository.GetAllProductsAsync();
           return Ok(products); 
        }
    }
}