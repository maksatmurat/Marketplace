using System.ComponentModel.DataAnnotations;

namespace Shared.Models;
public sealed class Category
{
    public Guid CategoryId { get; set; } = Guid.NewGuid();
    public Guid? ParentId { get; set; }
    [Required(ErrorMessage = "Hokman Yazmaly")]
    public string? CategoryName { get; set; }
    public Category? Parent { get; set; }
    public List<Category> Children { get; set; } = new();
    public List<Product> Products { get; set; } = new();

}
