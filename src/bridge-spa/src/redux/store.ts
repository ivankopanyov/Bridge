import { configureStore } from '@reduxjs/toolkit';
import hostListReducer from '../features/HostList/HostListStore';
import logListReducer from '../features/LogList/LogListStore';
import environmentReducer from '../features/Environment/EnvironmentStore';

export const store = configureStore({
    reducer: {
        hostList: hostListReducer,
        logList: logListReducer,
        environment: environmentReducer
    }
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;