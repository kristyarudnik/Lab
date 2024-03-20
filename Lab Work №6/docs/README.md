# Лабораторная работа №6
**Тема:** Использование шаблонов проектирования

**Цель работы:** Получить опыт применения шаблонов проектирования при написании кода программной системы.

## Шаблоны проектирования GoF
## Порождающие шаблоны
### 1. Строитель. Используется для создания объекта комнаты с определенными параметрами.
#### [Интерфейс строителя объекта комнаты](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IRoomBuilder.cs)
#### [Конкретный класс-строитель объекта комнаты](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/RoomBuilder.cs)
#### [Класс, который создает строитель](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/Room.cs)
#### [Распорядитель - создает комнату, используя объект roomBuilder](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Controllers/RoomsController.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/builder.jpg)

### 2. Фабричный метод. Используется для создания объектов-комнат разных типов, при добавлении в систему новой комнаты.
#### [Базовый класс объектов, которые создает фабрика](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/BaseRoom.cs)
#### [Интерфейс фабрики](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IRoomFactory.cs)
#### [Конкретный класс-создатель комнат типа "Standart"](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Factories/StandardRoomFactory.cs)
#### [Конкретный класс-создатель комнат типа "Suite"](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Factories/SuiteRoomFactory.cs)
#### [Класс комнаты типа "Standart"](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/RoomStandart.cs)
#### [Класс комнаты типа "Suite"](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/RoomSuite.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/factory.jpg)

### 3. Одиночка. Используется для создания единственного экземпляра фабрики объектов-комнат.
#### [Код класса](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Factories/RoomFactorySingleton.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/singleton.jpg)

## Структурные шаблоны
### 1. Адаптер. Используется для преобразования интерфейса класса IExternalGeolocationService в интерфейс IGeolocationService.
#### [Адаптируемый класс](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/ExternalGeolocationService.cs)
#### [Класс - адаптер](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/ExternalGeolocationAdapter.cs)
#### [Интерфейс, который используется клиентом](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/GeoServices/IGeolocationService.cs)
#### [Клиентский код, который использует объект IGeolocationService](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Controllers/CoodsController.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/adapter.jpg)

### 2. Заместитель (прокси). Предоставляет объект-заместитель, который управляет доступом к сервису сервиса geolocation в зависимости от того авторизован пользователь или нет.
#### [Класс-заместитель](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/GeolocationProxy.cs)
#### [Реализация сервиса geolocation](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/GeolocationService.cs)
#### [Интерфейс сервиса geolocation](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/GeoServices/IGeolocationService.cs)
#### [Использует сервис geolocation](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Controllers/CoodsController.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/proxy.jpg)

### 3. Декоратор. Используется для расширения функционала класса BaseRoom.
#### [Абстрактный класс декоратора](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/RoomDecorator.cs)
#### [Интерфейс для наследуемых объектов](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IRoom.cs)
#### [Конкретная реализация компонента, в которую добавляется новая функциональность](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/BaseRoom.cs)
#### [Декоратор, который представляет дополнительную функциональность для вывода рейтинга комнаты](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Decorators/RatingDecorator.cs)
#### [Декоратор, который представляет дополнительную функциональность для вывода статуса комнаты](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Decorators/BookingDecorator.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/decorator.jpg)

### 4. Фасад. Предоставляет интерфейс для работы взаимодействия с объектами-комнатами.
#### [Класс-фасад, который предоставляет интерфейс клиентскому коду для работы с компонентами](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/RoomFacade.cs)
#### [Компонент фасада, предоставляет функционал выставления оценки комнате](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/FacadeElements/RoomRatingService.cs)
#### [Компонент фасада, предоставляет функционал бронирования комнаты](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/FacadeElements/RoomBookingService.cs)
#### [Клиентский код, взаимодействует с фасадом](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Controllers/RoomsController.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/facade.jpg)

## Поведенческие шаблоны
### 1. Шаблонный метод. Алгоритм выставления рейтинга комнате.
#### [Абстрактный класс-шаблон алгоритма выставления рейтинга комнате](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/RoomRatingAlgorithm.cs)
#### [Класс, который выставляет рейтинг стандартной комнате](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/DefaultRoomRatingAlgorithm.cs)
#### [Класс, который выставляет рейтинг Suite комнате](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/VipRoomRatingAlgorithm.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/template.jpg)

### 2. Цепочка обязанностей. Исползуется для логирования событий бронирования комнаты и выставления ей рейтинга.
#### [Интерфейс для обработки запроса](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IHandler.cs)
#### [Абстрактный класс-обработчик](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/Handler.cs)
#### [Класс-клиент, который отправляет запрос обработчику](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Handlers/HandlerChain.cs)
#### [Класс-обработчик, который логирует в выставление рейтинга комнате](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Handlers/RatingHandler.cs)
#### [Класс-обработчик, который логирует бронирование комнаты](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Handlers/BookingHandler.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/chain.jpg)

### 3. Стратегия. Используется для преобразования рейтинга в текстовое представление в зависимости от локализации.
#### [Интерфейс стратегии](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IRatingConversionStrategy.cs)
#### [Стратегия, которая отвечает за преобразование рейтинга в текстовое представление для en](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Strategies/RussianRatingConversionStrategy.cs)
#### [Стратегия, которая отвечает за преобразование рейтинга в текстовое представление для ru](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Strategies/EnglishRatingConversionStrategy.cs)
#### [Клиентский код, который использует стратегию](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Controllers/RoomsController.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/strategy.jpg)

### 4. Наблюдатель. Используется, чтобы наблюдатели могли подписываться на события изменения состояния объекта-комнаты.
#### [Интерфейс наблюдателя](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IObserver.cs)
#### [Реализация наблюдателя](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Observers/BookingNotification.cs)
#### [Реализация наблюдателя](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/Observers/RatingUpdate.cs)
#### [Представляет наблюдаемый объект, определяет методы подписки, отписки, публикации](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/Room.cs)
#### [Клиентский код](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Controllers/RoomsController.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/observer.jpg)

### 5. Состояние. Используется для изменения поведения класса комнаты в зависимости от того в каком она статусе (состоянии).
#### [Класс комнаты, поведение которого должно динамически изменяться в соответствии с состоянием](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Models/RoomWithState.cs)
#### [Состояние, когда комната свободна](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/States/AvailableState.cs)
#### [Состояние, когда комната забронирована](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/States/BookedState.cs)
#### [Состояние, когда в комнату заехали жильцы](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Implementation/States/OccupiedState.cs)
#### [Интерфейс состояния](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/src/Interfaces/IRoomState.cs)
![img](https://github.com/kristyarudnik/Lab/blob/LabWork6/Lab%20Work%20%E2%84%966/docs/images/state.jpg)