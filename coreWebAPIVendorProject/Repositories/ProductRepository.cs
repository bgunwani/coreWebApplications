using coreWebAPIVendorProject.Data;
using coreWebAPIVendorProject.Models;

namespace coreWebAPIVendorProject.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> GetAll() => _context.Products.ToList();

        public Product? GetById(int id) => _context.Products.FirstOrDefault(x => x.Id == id);

        public void Update(Product product)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                _context.Products.Update(existingProduct);
                _context.SaveChanges();
            }
        }
    }
}
