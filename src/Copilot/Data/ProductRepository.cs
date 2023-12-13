using Copilot.Business;
using Microsoft.EntityFrameworkCore;

namespace Copilot.Data
{
    public class ProductRepository
    {
        private readonly CopilotContext _dbContext;

        public ProductRepository(CopilotContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddAsync(Product product)
        {
            _dbContext.Product.Add(product);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            return await _dbContext.Product.ToListAsync();
        }
    }
}
