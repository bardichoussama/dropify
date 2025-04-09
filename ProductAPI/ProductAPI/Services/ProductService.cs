using ProductAPI.DTOs;
using ProductAPI.Models;
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
        public void Add(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId
            };
            _repository.Add(product);
        }
        public void Update(int id, ProductDto productDto)
        {
            var product = _repository.GetById(id);

            if (product == null)
                throw new Exception("Product not found");

            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.CategoryId = productDto.CategoryId;

            _repository.Update(product);
        }


        public ProductDto GetById(int id)
        {
            var product = _repository.GetById(id);
            if (product == null) return null;
            return
                new ProductDto
                {
                    Name = product.Name,
                    Price = product.Price,
                    CategoryId = product.CategoryId
                };
        }
       public void Delete(int id)
        {
            _repository.DeleteById(id);
        }
    }

}
