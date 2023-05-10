using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Shared.Models;

public sealed class Product
{
    public Guid ProductId { get; set; } = Guid.NewGuid();
    [Required(ErrorMessage = "Hokman ady Yazmaly")]
    public string? ProductName { get; set; }
    [Required(ErrorMessage = "Hokman sany Yazmaly")]
    public double Quantity { get; set; }
    public string? Barcode { get; set; }
    [Required(ErrorMessage = "Hokman satyn alynan bahasyny Yazmaly")]
    public double BoughtPriceInNewManat { get; set; }
    public double BoughtPriceInOldManat { get; set; }
    public double SellPriceInNewManat { get; set; }
    public double SellPriceInOldManat { get; set; }
    [Required(ErrorMessage = "Hokman skidka Yazmaly")]
    [Range(0, 1, ErrorMessage = "Sany (0.01-1) gir")]
    public double Discount { get; set; }
    public double DiscountInManat { get; set; }
    [Required(ErrorMessage = "Hokman gorulecek peyda Yazmaly")]
    public double PlusManat { get; set; }

    [Required]
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<BoughtProduct> BoughtProducts { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();

}
