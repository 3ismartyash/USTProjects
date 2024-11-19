using CodePulse.API.Models.Domian;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsnyc(Category category);
    }
}
