import React from 'react';

const BookingFormResult = ({ isAvailable, error }) => {
    return (
        <div>
            <p>{isAvailable ? 'Номер доступен!' : 'Номер не доступен.'}</p>
            {error && <p style={{ color: 'red' }}>{error}</p>}
        </div>
    );
};

export default BookingFormResult;