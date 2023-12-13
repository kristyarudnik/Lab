// bookingFormSlice.js
import { createSlice } from '@reduxjs/toolkit';

const initialState = {
  formData: {
    roomType: '',
    date: '',
  },
  isAvailable: false,
  loading: false,
  error: null,
};

const bookingFormSlice = createSlice({
  name: 'bookingForm',
  initialState,
  reducers: {
    setFormData: (state, action) => {
      state.formData = action.payload;
    },
    setAvailability: (state, action) => {
      state.isAvailable = action.payload;
    },
    setLoading: (state, action) => {
      state.loading = action.payload;
    },
    setError: (state, action) => {
      state.error = action.payload;
    },
    resetForm: (state) => {
      state.formData = initialState.formData;
      state.isAvailable = initialState.isAvailable;
      state.loading = initialState.loading;
      state.error = initialState.error;
    },
  },
});

export const {
  setFormData,
  setAvailability,
  setLoading,
  setError,
  resetForm,
} = bookingFormSlice.actions;

export default bookingFormSlice.reducer;
