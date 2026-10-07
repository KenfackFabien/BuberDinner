using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Dinner.ValueObjects;

public sealed class UpcomingDinnerId : ValueObject
{
    public Guid Value { get; }

    private UpcomingDinnerId(Guid value)
    {
        Value = value;
    }

    public static UpcomingDinnerId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}