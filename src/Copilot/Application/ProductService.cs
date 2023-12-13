using Copilot.Data;

namespace Copilot.Application
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<ProductModel>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateProductAsync(CreateProductCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
