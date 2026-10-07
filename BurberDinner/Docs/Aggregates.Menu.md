# Domain Models

## Menu

```csharp
class Menu
{
    // TODO: Add methods
}
```


```json
{
  "id": "000000000-0000-0000-0000-000000000",
  "name": "Yummy Meu",
  "description": "A menu witch ymmy food",
  "averageRating": 4.5,
  "sections": [
    {
      "id": "000000000-0000-0000-0000-000000000",
      "name": "Appetizers",
      "description": "starters",
      "items": [
        {
          "id": "000000000-0000-0000-0000-000000000",
          "name": "Fried Pickles",
          "description": "Deep fried pickles",
          "prices": 5.99
        }
      ]
    }
  ],
  "hostID": "000000000-0000-0000-0000-000000000",
  "dinnerIds": [
    "000000000-0000-0000-0000-000000000",
  ], 
  "menuReviewIds": [
    "000000000-0000-0000-0000-000000000"
  ],
  "createdDateTime": "2026-02-19T00:00:00.000000000Z",
  "updatedDateTime": "2026-02-19T00:00:00.000000000Z"
}
```