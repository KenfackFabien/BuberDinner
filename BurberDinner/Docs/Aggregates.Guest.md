# Domain Agregates

## Guest

```csharp
class Guest
{
    // TODO: Add methods
}
```

```json
{
    "id": { "value": "000000000-0000-0000-0000-000000000" },
    "firstName": "John",
    "lastName": "Doe",
    "profileImage": "https://www.gravatar.com/avatar/000000000000000000000000000?d=mp",
    "averageRating": 4.5,
    "userId": { "value": "000000000-0000-0000-0000-000000000" },
    "upcomingDinnerIds": [
        { "value": "000000000-0000-0000-0000-000000000" }
    ],
    "pastDinnerIds": [
        { "value": "000000000-0000-0000-0000-000000000" }
    ],
    "pendingDinnerIds": [
        { "value": "000000000-0000-0000-0000-000000000" }
    ],
    "billIds": [
        { "value": "000000000-0000-0000-0000-000000000" }
    ],
    "menuReviewIds": [
        { "value": "000000000-0000-0000-0000-000000000" }
    ],
    "ratings": [
        {
            "id": { "value": "000000000-0000-0000-0000-000000000" },
            "hostId": { "value": "000000000-0000-0000-0000-000000000" },
            "dinnerId": { "value": "000000000-0000-0000-0000-000000000" },
            "rating": 4,
            "createdDateTime": "2020-01-01T00:00:00.000000000Z",
            "updatedDateTime": "2020-01-01T00:00:00.000000000Z"
        }
    ],
    "createdDateTime": "2020-01-01T00:00:00.000000000Z",
    "updatedDateTime": "2020-01-01T00:00:00.000000000Z"
}
```