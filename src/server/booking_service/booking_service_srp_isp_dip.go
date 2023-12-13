// интерфейс для проверки доступности номера
type RoomAvailabilityChecker interface {
	CheckAvailability(formData map[string]interface{}) (bool, error)
}

// интерфейс для бронирования номера
type RoomReserver interface {
	ReserveRoom(formData map[string]interface{}) error
}

// представляет интерфейс для сохранения данных бронирования
type BookingRepository interface {
	SaveBookingData(formData map[string]interface{}) error
}

// представляет собой сервис бронирования номеров
type BookingService struct {
	AvailabilityChecker RoomAvailabilityChecker
	RoomReserver        RoomReserver
	BookingRepository   BookingRepository
}

// создает новый экземпляр сервиса бронирования
func NewBookingService(ac RoomAvailabilityChecker, rr RoomReserver, br BookingRepository) *BookingService {
	return &BookingService{
		AvailabilityChecker: ac,
		RoomReserver:        rr,
		BookingRepository:   br,
	}
}

// выполняет проверку доступности номера
func (bs *BookingService) CheckAvailability(formData map[string]interface{}) (bool, error) {
	// логика валидации данных
	if _, ok := formData["roomType"]; !ok {
		return false, errors.New("roomType is required")
	}

	// выполняем запрос к внешней системе через интерфейс AvailabilityChecker
	isAvailable, err := bs.AvailabilityChecker.CheckAvailability(formData)
	if err != nil {
		return false, err
	}

	return isAvailable, nil
}

// выполняет бронирование номера
func (bs *BookingService) ReserveRoom(formData map[string]interface{}) error {
	// логика валидации данных
	if _, ok := formData["roomType"]; !ok {
		return errors.New("roomType is required")
	}

	// выполняем запрос к внешней системе через интерфейс RoomReserver
	err := bs.RoomReserver.ReserveRoom(formData)
	if err != nil {
		return err
	}

	// сохраняем данные о бронировании в нашей базе данных через интерфейс BookingRepository
	return bs.BookingRepository.SaveBookingData(formData)
}

