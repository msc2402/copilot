using System.ComponentModel.DataAnnotations;
using Copilot.Business;

namespace Copilot.Application
{
    public class CreateProductCommand : ICreateProductSpec
    {
        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        public string Sku { get; set; } = default!;

        [Required]
        [MinLength(5)]
        public string Name { get; set; } = default!;

        [Required]
        [MinLength(10)]
        public string Description { get; set; } = default!;
    }
}
