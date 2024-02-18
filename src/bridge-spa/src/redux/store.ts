import { configureStore } from '@reduxjs/toolkit';
import serviceReducer from "../features/serviceSlice";

export const store = configureStore({
    reducer: {
        services: serviceReducer
    }
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;