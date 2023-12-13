// интерфейс репозитория для сохранения данных бронирования
type BookingRepository interface {
	SaveBookingData(formData map[string]interface{}) error
}

// реализация BookingRepository
type SQLBookingRepository struct {
	// код для работы с SQL-базой данных
}

// сохраняет данные о бронировании в SQL-базе данных
func (br *SQLBookingRepository) SaveBookingData(formData map[string]interface{}) error {
	// код сохранения данных в SQL-базе данных
	return nil
}