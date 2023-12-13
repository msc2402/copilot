using Copilot.Application;
using Microsoft.AspNetCore.Mvc;

namespace Copilot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductModel>> Get()
        {
            return await _productService.GetProductsAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommand command)
        {
            if (await _productService.CreateProductAsync(command))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
