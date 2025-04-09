using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.DTOs;
using ProductAPI.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(_productService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var  product = _productService.GetById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Add  (ProductDto productDto)
        {
            _productService.Add(productDto);
            return Ok(new { message = "Product added successfully" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ProductDto productDto) {
            _productService.Update(id, productDto);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok(new { message = "Product deleted successfully" }); // ✅ Returns JSON response
        }

    }
}
