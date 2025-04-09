using ProductAPI.DTOs;

namespace ProductAPI.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
        void Add(ProductDto productDto);
        void Update(int id, ProductDto productDto);
        void Delete(int id);
    }
}
