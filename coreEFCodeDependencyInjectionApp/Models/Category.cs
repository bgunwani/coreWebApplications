namespace coreEFCodeDependencyInjectionApp.Models
{
    public class Category
    {
        // Scalary Properties
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
