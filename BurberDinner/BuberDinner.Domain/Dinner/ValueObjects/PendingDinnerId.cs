using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Dinner.ValueObjects;

public sealed class PendingDinnerId : ValueObject
{
    public Guid Value { get; }

    private PendingDinnerId(Guid value)
    {
        Value = value;
    }

    public static PendingDinnerId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}