using CodePulse.API.Data;
using CodePulse.API.Models.Domian;
using CodePulse.API.Repositories.Interface;

namespace CodePulse.API.Repositories.implementation
{
    public class categoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public categoryRepository(ApplicationDbContext dbContext)

        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsnyc(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
