using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public sealed class BoughtProduct
{
    public Guid BoughtProductId { get; set; } = Guid.NewGuid();
    [Required]
    public double Quantity { get; set; }
    [Required]
    public double BoughtPriceNewManat { get; set; }
    [Required]
    public double BoughtPriceOldManat { get; set; }
    [Required]
    public DateTime BoughtDateTime { get; set; }
    [Required]
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
}

