using ProductAPI.DTOs;

namespace ProductAPI.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAll();
    }
}
