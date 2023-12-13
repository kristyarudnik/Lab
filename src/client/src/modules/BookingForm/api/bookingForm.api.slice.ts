import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';

export const bookingFormApi = createApi({
  reducerPath: 'bookingFormApi',
  baseQuery: fetchBaseQuery({ baseUrl: '/api' }), // Укажите базовый URL вашего API
  endpoints: (builder) => ({
    checkAvailability: builder.mutation({
      query: (formData) => ({
        url: '/check-availability',
        method: 'POST',
        body: formData,
      }),
    }),
    reserveRoom: builder.mutation({
      query: (formData) => ({
        url: '/reserve-room',
        method: 'POST',
        body: formData,
      }),
    }),
  }),
});

export const { useCheckAvailabilityMutation, useReserveRoomMutation } = bookingFormApi;
