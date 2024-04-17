import { configureStore } from '@reduxjs/toolkit';
import hostListReducer from '../features/HostList/HostListStore';

export const store = configureStore({
    reducer: {
        hostList: hostListReducer
    }
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;