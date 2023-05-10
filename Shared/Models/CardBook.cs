using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Shared.Models;

public sealed class CardBook
{
    public Guid CardBookId { get; set; } = Guid.NewGuid();
    [Required(ErrorMessage = "Hokman ady Yazmaly")]
    public string? CardsName { get; set; }
    [Required(ErrorMessage = "Hokman sany Yazmaly")]
    public double Quantity { get; set; }
    [Required(ErrorMessage = "Hokman satys puly taze manat Yazmaly")]
    public double SellPriceNewManat { get; set; }
    [Required(ErrorMessage = "Hokman satys puly kone manat Yazmaly")]
    public double SellPriceOldManat { get; set; }
    [Required(ErrorMessage = "Hokman satys taryhy Yazmaly")]
    public DateTime SellDateTime { get; set; }
    [Required]
    public Guid TransactionId { get; set; }
    public Transaction? Transaction { get; set; }
}

