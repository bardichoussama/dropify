using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext dbContext;
        public CategoryRepository(AppDbContext dbContext) { 
            this.dbContext = dbContext;

        }

         public IEnumerable<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }

    }
}
