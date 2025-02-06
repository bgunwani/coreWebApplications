using coreWebAPIVendorProject.Models;
using coreWebAPIVendorProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreWebAPIVendorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public List<Product> GetProducts() 
        {
            return _productRepository.GetAll();
        }
    }
}
