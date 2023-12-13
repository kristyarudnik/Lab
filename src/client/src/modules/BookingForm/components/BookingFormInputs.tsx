import React from 'react';
import BookingFormInput from '../../../components/BookingFormInput';

const BookingFormInputs = ({ formData, handleChange }) => {
    return (
        <div>
            <BookingFormInput
                label="Тип номера"
                name="roomType"
                value={formData.roomType}
                onChange={handleChange}
            />
            <BookingFormInput
                label="Дата"
                name="date"
                type="date"
                value={formData.date}
                onChange={handleChange}
            />
        </div>
    );
};

export default BookingFormInputs;