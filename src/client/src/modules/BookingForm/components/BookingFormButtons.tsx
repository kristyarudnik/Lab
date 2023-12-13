import React from 'react';

const BookingFormButtons = ({ checkAvailability, reserveRoom, isAvailable, loading }) => {
    return (
        <>
            <Button type="button" onClick={checkAvailability} disabled={loading}>
                Проверить доступность
            </Button>
            <Button type="button" onClick={reserveRoom} disabled={!isAvailable || loading}>
                Забронировать
            </Button>
        </>
    );
};

export default BookingFormButtons;