using BuberBill.Domain.Bill.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Guest.ValueObjects;
using BuberDinner.Domain.Menu.Entities;
using BuberDinner.Domain.MenuReview.ValueObjects;
using BuberDinner.Domain.User.ValueObjects;

namespace BuberDinner.Domain.Guest;

public sealed class Guest : AggregateRoot<GuestId>
{
    private List<UpcomingDinnerId> _upcomingDinnerIds = new();
    private List<PastDinnerId> _pastDinnerIds = new();
    private List<PendingDinnerId> _pendingDinnerIds = new();
    private List<BillId> _billIds = new();
    private List<MenuReviewId> _menuReviewIds = new();
    private List<GuestRating> _guestRatings = new();

    public string FirstName { get; }
    public string LastName { get; }
    public string ProfileImage { get; }
    public float AverageRating { get; }    
    public UserId UserId { get; }

    public IReadOnlyList<UpcomingDinnerId> UpcomingDinnerIds => _upcomingDinnerIds.AsReadOnly();
    public IReadOnlyList<PastDinnerId> PastDinnerIds => _pastDinnerIds.AsReadOnly();
    public IReadOnlyList<PendingDinnerId> PendingDinnerIds => _pendingDinnerIds.AsReadOnly();
    public IReadOnlyList<BillId> BillIds => _billIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
    public IReadOnlyList<GuestRating> GuestRatings => _guestRatings.AsReadOnly();

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Guest(
        GuestId GuestID,
        string firstName,
        string lastName,
        string profileImage,
        float averageRating,
        UserId userId,
        DateTime createdDateTime,
        DateTime updatedDateTime
    ) : base(GuestID)
    {
        FirstName = firstName;
        LastName = lastName;
        ProfileImage = profileImage;
        AverageRating = averageRating;
        UserId = userId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Guest Create(
        string firstName,
        string lastName,
        string profileImage,
        float averageRating,
        UserId userId
    )
    {
        return new
        (
            GuestId.CreateUnique(),
            firstName,
            lastName,
            profileImage,
            averageRating,
            userId,
            DateTime.UtcNow,
            DateTime.UtcNow
        );
    }
}