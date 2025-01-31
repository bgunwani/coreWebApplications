using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class Product
    {
        // Scalar Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        // Navigation Properties
        public Category? Category { get; set; }
    }
}
