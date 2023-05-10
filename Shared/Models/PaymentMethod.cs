using System.Transactions;

namespace Shared.Models;

public sealed class PaymentMethod
{
    public Guid PaymentMethodId { get; set; } = Guid.NewGuid();
    public string? PaymentMethodName { get; set; }
    public List<Transaction> Transactions { get; set; } = new();
}

