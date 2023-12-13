import { useState } from 'react';
import { useCheckAvailabilityMutation, useReserveRoomMutation } from '../bookingFormApi';
import {
    setFormData,
    setAvailability,
    setLoading,
    setError,
    resetForm,
} from '../bookingFormSlice';
import { useDispatch, useSelector } from 'react-redux';
import {
    selectFormData,
    selectIsAvailable,
    selectLoading,
    selectError,
} from '../bookingFormSelectors';

export const useBookingForm = () => {
    const dispatch = useDispatch();
    const formData = useSelector(selectFormData);
    const isAvailable = useSelector(selectIsAvailable);
    const loading = useSelector(selectLoading);
    const error = useSelector(selectError);

    const [checkAvailabilityMutation] = useCheckAvailabilityMutation();
    const [reserveRoomMutation] = useReserveRoomMutation();

    const handleChange = (e) => {
        dispatch(setFormData({ ...formData, [e.target.name]: e.target.value }));
    };

    const checkAvailability = async () => {
        dispatch(setLoading(true));

        try {
            const result = await checkAvailabilityMutation(formData);
            dispatch(setAvailability(result.data.isAvailable));
        } catch (error) {
            dispatch(setError(error.message));
        } finally {
            dispatch(setLoading(false));
        }
    };

    const reserveRoom = async () => {
        dispatch(setLoading(true));

        try {
            await reserveRoomMutation(formData);
            alert('Номер успешно забронирован!');
            dispatch(resetForm());
        } catch (error) {
            alert('Произошла ошибка при бронировании номера.');
            dispatch(setError(error.message));
        } finally {
            dispatch(setLoading(false));
        }
    };

    const resetFormAndResult = () => {
        dispatch(resetForm());
    };

    return {
        formData,
        isAvailable,
        loading,
        error,
        handleChange,
        checkAvailability,
        reserveRoom,
        resetForm: resetFormAndResult,
    };
};
