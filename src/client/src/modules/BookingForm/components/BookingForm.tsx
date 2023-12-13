import React from 'react';

import BookingFormInputs from './BookingFormInputs';
import BookingFormButtons from './BookingFormButtons';
import BookingFormResult from './BookingFormResult';

const BookingForm = () => {
    const {
        formData,
        isAvailable,
        loading,
        error,
        handleChange,
        checkAvailability,
        reserveRoom,
        resetForm,
    } = BookingForm();

    return (
        <div>
            <h2>Форма бронирования</h2>
            <form>
                <BookingFormInputs formData={undefined} handleChange={undefined} />
                <BookingFormButtons
                    checkAvailability={checkAvailability}
                    reserveRoom={reserveRoom}
                    isAvailable={isAvailable}
                    loading={loading}
                />
                <BookingFormResult isAvailable={isAvailable} error={error} />
            </form>
        </div>
    );
};

export default BookingForm;
