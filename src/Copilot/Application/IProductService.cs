namespace Copilot.Application
{
    public interface IProductService
    {
        Task<IList<ProductModel>> GetProductsAsync();
        Task<bool> CreateProductAsync(CreateProductCommand command);
    }
}
