using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void DeleteById(int id);

        //Task<IEnumerable<Product>> GetAllAsync();
        //Task<Product?> GetByIdAsync(int id);
        //Task AddAsync(Product product);
        //Task UpdateAsync(Product product);
        //Task DeleteAsync(int id);

    }
}
