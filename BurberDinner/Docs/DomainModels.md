# Domain Models

## Menu

```csharp
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
  ]
}
```

## User

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "password": "Amiko1232!"
}
```

> Note: Passwords shouldn't be laying around like this ⚠️