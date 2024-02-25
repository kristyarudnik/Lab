## Лабораторная работа 4 ##

Ссылка на тестирование 

## Ресурс stream-data/schemas

Ссылка

## Методы

# Hotel Booking API Documentation

Данный ресурс предоставляет методы для работы с комнатами (номерами) отеля. Их бронирование, оценка и т.д.

## Методы

### Получить список всех комнат

- **Method:** `GET`
- **URL:** `/api/Rooms`
- **Request Parameters:** None
- **Response:** `200 OK`
- **Response Body:**
  ```json
  [
    {
      "id": 1,
      "type": "Single",
      "location": "1st floor",
      "isAvailable": true,
      "rating": 4.5
    },
     ...
  ]
  ```

### Получить информацию о комнате по ID

- **Method:** `GET`
- **URL:** `/api/Rooms/{id}`
- **Request Parameters:**
  - `id` (path) - ID комнаты.
- **Response:** `200 OK` | `404 Not Found`
- **Response Body (200):**
  ```json
  {
    "id": 1,
    "type": "Single",
    "location": "1st floor",
    "isAvailable": true,
    "rating": 4.5
  }
  ```

### Добавить информацию о новой комнате

- **Method:** `POST`
- **URL:** `/api/Rooms`
- **Request Body:**
  ```json
  {
    "type": "Double",
    "location": "2nd floor",
    "isAvailable": true,
    "rating": 4.0
  }
  ```
- **Response:** `201 Created`
- **Response Body:**
  ```json
  {
    "id": 2,
    "type": "Double",
    "location": "2nd floor",
    "isAvailable": true,
    "rating": 4.0
  }
  ```

### Обновить информацию по комнате

- **Method:** `PUT`
- **URL:** `/api/Rooms/{id}`
- **Request Parameters:**
  - `id` (path) - ID комнаты.
- **Request Body:**
  ```json
  {
    "id": 2,
    "type": "Double",
    "location": "3rd floor",
    "isAvailable": false,
    "rating": 4.2
  }
  ```
- **Response:** `204 No Content`

### Удалить информацию по комнате

- **Method:** `DELETE`
- **URL:** `/api/Rooms/{id}`
- **Request Parameters:**
  - `id` (path) - ID комнаты.
- **Response:** `204 No Content`

### Оценить комнату

- **Method:** `PUT`
- **URL:** `/api/Rooms/{id}/Rate`
- **Request Parameters:**
  - `id` (path) - ID комнаты.
- **Request Body:**
  ```json
  {
    "rating": 4.8
  }
  ```
- **Response:** `204 No Content`

### Забронировать комнату

- **Method:** `PUT`
- **URL:** `/api/Rooms/{id}/Reserve`
- **Request Parameters:**
  - `id` (path) - ID комнаты.
- **Response:** `204 No Content`

### Отменить бронирование комнаты

- **Method:** `PUT`
- **URL:** `/api/Rooms/{id}/Cancel`
- **Request Parameters:**
  - `id` (path) - ID комнаты.
- **Response:** `204 No Content`
