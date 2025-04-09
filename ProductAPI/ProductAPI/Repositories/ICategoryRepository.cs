using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}
