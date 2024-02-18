import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { RootState } from '../redux/store';
import Service from '../models/Service';
import Host from '../models/Host';

const initialState: Host[] = [];

export const serviceSlice = createSlice({
    name: "services",
    initialState,
    reducers: {
        init(state, action: PayloadAction<Host[]>) {
            state.splice(0, state.length);
            state.push(...action.payload);
        },
        set(state, action: PayloadAction<Service>) { 
            const host = state.find(h => h.name === action.payload.hostName);
            if (!host) {
                state.push({
                    name: action.payload.hostName,
                    services: [action.payload]
                });
            } else {
                const index = host.services.findIndex(s => s.name === action.payload.name);
                index >= 0
                    ? host.services[index] = action.payload
                    : host.services.push(action.payload);
            }
        }
    }
});

export const {
    init,
    set
} = serviceSlice.actions;

export const services = (state: RootState) => state.services;

export default serviceSlice.reducer;