## 1.Получить список всех комнат 

* URI: /api/Rooms
* Тип запроса: GET 
* Код тестов для для данного метода 

```
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});
pm.test("Content-Type is application/json", function () {
    pm.expect(pm.response.headers.get('Content-Type')).to.include('application/json');
});
pm.test("Response contains array of rooms", function () {
    var jsonData = pm.response.json();
    pm.expect(jsonData).to.be.an('array');
});
```
![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Получить%20список%20всех%20комнат.jpg)


## 2. Получить информацию о комнате по ID

* URI: /api/Rooms/:id
* Тип запроса: GET 
* Код тестов для для данного метода 
```
pm.test("Status code is 200 and room details are correct", function () {
    pm.response.to.have.status(200);
    var jsonData = pm.response.json();
    pm.expect(jsonData.id).to.eql(1); 
    pm.expect(jsonData).to.have.property('type');
    pm.expect(jsonData).to.have.property('location');
    pm.expect(jsonData).to.have.property('isAvailable');
});
pm.test("Id equals 1", function () {
    var jsonData = pm.response.json();
    pm.expect(jsonData.id).to.eql(1); 
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Получить%20информацию%20о%20комнате%20по%20ID.jpg)


## 3. Добавить информацию о новой комнате

* URI: /api/Rooms
* Тип запроса: POST
* Код тестов для для данного метода
```
pm.test("Status code is 201 Created", function () {
    pm.response.to.have.status(201);
});

pm.test("Response contains room ID", function () {
    var jsonData = pm.response.json();
    pm.expect(jsonData).to.have.property('id');
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Добавить%20информацию%20о%20новой%20комнате.jpg)


## 4. Обновить информацию по комнате

* URI: /api/Rooms/:id
* Тип запроса: PUT
* Код тестов для для данного метода
```
pm.test("Status code is 204 No Content on success", function () {
    pm.response.to.have.status(204);
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Обновить%20информацию%20по%20комнате.jpg)



## 5. Удалить информацию по комнате

* URI: /api/Rooms/:id
* Тип запроса: DELETE
* Код тестов для для данного метода
```
pm.test("Status code is 204 No Content on successful deletion", function () {
    pm.response.to.have.status(204);
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Удалить%20информацию%20по%20комнате.jpg)

## 6. Оценить комнату

* URI: /api/Rooms/:id/Rate
* Тип запроса: PUT
* Код тестов для для данного метода
```
pm.test("Status code is 204 No Content on successful rating update", function () {
    pm.response.to.have.status(204);
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Оценить%20комнату.jpg)


## 7. Забронировать комнату

* URI: /api/Rooms/:id/Reserve
* Тип запроса: PUT
* Код тестов для для данного метода
```
pm.test("Status code is 204 No Content on successful reservation and verify no body", function () {
    pm.response.to.have.status(204);
});

pm.test("Is success", function () {
    pm.response.to.be.success;
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Забронировать%20комнату.jpg)


## 8. Отменить бронирование комнаты

* URI: /api/Rooms/:id/CancelReservation
* Тип запроса: PUT
* Код тестов для для данного метода

```
pm.test("Status code is 204 No Content on successful reservation and verify no body", function () {
    pm.response.to.have.status(204);

});

pm.test("Is success", function () {
    pm.response.to.be.success;
});
```

![img](https://github.com/kristyarudnik/Lab/blob/LabWork4/Lab%20Work%20№4/docs/images/Отменить%20бронирование%20комнаты.jpg)

