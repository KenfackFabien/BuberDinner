# Buber Dinner API

## Table of Contents (up to date)
- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "password": "Amiko123!"
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "c3f1a2b4-5678-4d9e-9012-abcdef123456",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request 

```json
{
  "email": "amichai@mantinband.com",
  "password": "Amiko1232!"
}
```

#### Login Response 

```json
{
  "id": "c3f1a2b4-5678-4d9e-9012-abcdef123456",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

