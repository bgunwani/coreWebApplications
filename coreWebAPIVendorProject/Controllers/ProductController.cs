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
        [HttpGet("id")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productRepository.GetById(id);
            return product == null ? NotFound() : Ok(product);
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _productRepository.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            _productRepository.Update(product);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            return NoContent();
        }
    }
}
