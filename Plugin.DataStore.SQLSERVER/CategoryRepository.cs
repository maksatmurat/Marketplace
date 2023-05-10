using Microsoft.EntityFrameworkCore;
using Shared.Models;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQLITE;

public class CategoryRepository : ICategoryRepository
{
    private readonly MarketDbContext _db;
    public CategoryRepository(MarketDbContext db)
    {
        _db = db;
    }

    public async Task<List<Category>> GetAllCategories() => await _db.Categories!.ToListAsync();

    public async Task<Category> GetCategoryById(Guid categoryId)
    {
        var category = await _db.Categories!.FindAsync(categoryId);
        if (category != null) return category;
        return null!;
    }

    public async Task GetDbCategories()
    {
        await _db.Categories!.Include(h => h.Parent).ToListAsync();
    }

}

