using Copilot.Business;
using Microsoft.EntityFrameworkCore;

namespace Copilot.Data
{
    public class CopilotContext : DbContext
    {
        public DbSet<Product> Product { get; set; } = default!;

        public CopilotContext(DbContextOptions<CopilotContext> options) : base(options)
        {
        }
    }
}
