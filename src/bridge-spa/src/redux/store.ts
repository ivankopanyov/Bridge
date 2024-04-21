import { configureStore } from '@reduxjs/toolkit';
import hostListReducer from '../features/HostList/HostListStore';
import logListReducer from '../features/LogList/LogListStore';

export const store = configureStore({
    reducer: {
        hostList: hostListReducer,
        logList: logListReducer
    }
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;