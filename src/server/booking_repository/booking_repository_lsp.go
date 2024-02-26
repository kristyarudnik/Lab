// интерфейс для чтения данных о бронировании из in memory хранилища
type BookingRepositoryRead interface {
	GetBookingData(bookingID string) (map[string]interface{}, error)
}

// реализация BookingRepositoryRead in memory хранилища
type InMemoryBookingRepository struct {
	bookings map[string]map[string]interface{}
	///
	/// код
	///
}

// возвращает данные о бронировании из хранилища.ё
func (br *InMemoryBookingRepository) GetBookingData(bookingID string) (map[string]interface{}, error) {
	///
	/// код логика и т д
	///
	if data, ok := br.bookings[bookingID]; ok {
		return data, nil
	}
	return nil, errors.New("booking not found")
}


