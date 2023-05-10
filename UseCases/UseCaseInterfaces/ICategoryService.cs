
using Shared.Models;

namespace UseCases.UseCaseInterfaces;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategories();
    Task<Category> GetCategoryById(Guid categoryId);
}

