using BuberBill.Domain.Bill.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Guest.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;
using BuberDinner.Domain.User.ValueObjects;

namespace BuberDinner.Domain.Guest;

public sealed class Guest : AggregateRoot<GuestId>
{
    private List<UpcomingDinnerId> _UpcomingDinnerIds = new();
    private List<PastDinnerId> _PastDinnerIds = new();
    private List<PendingDinnerId> _PendingDinnerIds = new();
    private List<BillId> _BillIds = new();
    private List<MenuReviewId> _MenuReviewIds = new();
    public string FirstName { get; }
    public string LastName { get; }
    public string ProfileImage { get; }
    public float AverageRating { get; }    
    public UserId UserId { get; }

    public IReadOnlyList<UpcomingDinnerId> UpcomingDinnerIds => _UpcomingDinnerIds.AsReadOnly();
    public IReadOnlyList<PastDinnerId> PastDinnerIds => _PastDinnerIds.AsReadOnly();
    public IReadOnlyList<PendingDinnerId> PendingDinnerIds => _PendingDinnerIds.AsReadOnly();
    public IReadOnlyList<BillId> BillIds => _BillIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _MenuReviewIds.AsReadOnly();

}