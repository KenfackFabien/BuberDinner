using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Guest.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.MenuReview;

public sealed class MenuReview : AggregateRoot<MenuReviewId>
{
    public int Rating;
    public string Comment;
    public HostId HostId;
    public MenuId MenuId;
    public GuestId GuestId;
    public DinnerId DinnerId;
    public DateTime CreatedDateTime;
    public DateTime UpdatedDateTime;

    private MenuReview(
        MenuReviewId MenuReviewId,
        int rating,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId,
        DateTime createdDateTime,
        DateTime updatedDateTime
    ) : base(MenuReviewId)
    {
        Rating = rating;
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        DinnerId = dinnerId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public MenuReview Create(
        int rating,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId
    )
    {
        return new(
            MenuReviewId.CreateUnique(),
            rating,
            comment,
            hostId,
            menuId,
            guestId,
            dinnerId,
            DateTime.UtcNow,
            DateTime.UtcNow
        );
    }
}