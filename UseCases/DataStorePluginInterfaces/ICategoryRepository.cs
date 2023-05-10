
using Shared.Models;

namespace UseCases.DataStorePluginInterfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllCategories();
    Task<Category> GetCategoryById(Guid categoryId);
}
