import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { RootState } from '../redux/store';
import Service from '../models/Service';
import Host from '../models/Host';
import RemoveHostDto from '../dto/RemoveHostDto';
import RemoveServiceDto from '../dto/RemoveServiceDto';
import SetOptionsDto from '../dto/SetOptionsDto';
import ResetOptionsDto from '../dto/ResetOptionsDto';

const initialState: Host[] = [];

export const serviceSlice = createSlice({
    name: "services",
    initialState,
    reducers: {
        set(state, action: PayloadAction<Service>) {
            const host = state.find(h => h.name === action.payload.hostName);
            if (!host) {
                state.push({
                    name: action.payload.hostName,
                    services: [action.payload]
                });
            } else {
                const service = host.services.find(s => s.name === action.payload.name);
                if (!service) {
                    host.services.push(action.payload);
                } else {
                    service.state = action.payload.state;
                    service.options = action.payload.options;
                    service.temp = action.payload.temp;
                }
            }
        },
        setRange(state, action: PayloadAction<Host[]>) {
            action.payload.forEach(h => {
                const host = state.find(host => h.name === host.name);
                if (!host) {
                    state.push({
                        name: h.name,
                        services: h.services
                    });
                } else {
                    h.services.forEach(s => {
                        const service = host.services.find(service => service.name === s.name);
                        if (!service) {
                            host.services.push(s);
                        } else {
                            service.state = s.state;
                            service.options = s.options;
                            service.temp = s.temp;
                        }
                    });
                }
            })
        },
        setOptions(state, action: PayloadAction<SetOptionsDto>) {
            const host = state.find(h => h.name === action.payload.hostName);
            if (host) {
                const service = host.services.find(s => s.name === action.payload.serviceName);
                if (service)
                    service.temp = action.payload.options;
            }
        },
        reset(state, action: PayloadAction<ResetOptionsDto>) {
            const host = state.find(h => h.name === action.payload.hostName);
            if (host) {
                const service = host.services.find(s => s.name === action.payload.serviceName);
                if (service)
                    service.temp = service.options ? [...service.options] : undefined;
            }
        },
        remove(state, action: PayloadAction<RemoveServiceDto>) {
            const host = state.find(h => h.name === action.payload.hostName);
            if (host) {
                const index = host.services.findIndex(s => s.name === action.payload.name);
                if (index >= 0) {
                    host.services.splice(index, 1);
                }
            }
        },
        removeRange(state, action: PayloadAction<RemoveHostDto>) {
            const index = state.findIndex(h => h.name === action.payload.name);
            if (index >= 0) {
                state.splice(index, 1);
            }
        }
    }
});

export const {
    set,
    setRange,
    setOptions,
    reset,
    remove,
    removeRange
} = serviceSlice.actions;

export const services = (state: RootState) => state.services;

export default serviceSlice.reducer;