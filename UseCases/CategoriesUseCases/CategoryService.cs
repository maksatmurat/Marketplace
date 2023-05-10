using Shared.Models;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CategoriesUseCases;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<Category>> GetAllCategories()
    {
        return await _categoryRepository.GetAllCategories();
    }

    public async Task<Category> GetCategoryById(Guid categoryId)
    {
        return await _categoryRepository.GetCategoryById(categoryId);
    }
}