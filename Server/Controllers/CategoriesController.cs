using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using UseCases.UseCaseInterfaces;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _context;

    public CategoriesController(ICategoryService context)
    {
        _context = context;
    }

    // GET: api/Categories
    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetCategories()
    {
        var categories = await _context.GetAllCategories();
        return Ok(categories);
    }

}

