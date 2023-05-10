using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public sealed class Transaction
{
    public Guid TransactionId { get; set; } = Guid.NewGuid();
    [Required]
    public DateTime TimeStamp { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public double BeforeQty { get; set; }
    [Required]
    public double SoldQty { get; set; }
    [Required]
    public string? CashierName { get; set; }
    [Required]
    public string? ProductName { get; set; }
    [Required]
    public Guid ProductId { get; set; }
    [Required]
    public Guid PaymentMethodId { get; set; }
    public Product? Product { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }
}

