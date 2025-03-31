using ProductAPI.DTOs;
using ProductAPI.Repositories;

namespace ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = _repository.GetAll();
            return products.Select(p => new ProductDto
            {
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId,
            });
        }
    }

}
