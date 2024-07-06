import { PayloadAction, createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { HostList, ServiceInfo, SimpleServiceInfo } from './data';
import { api } from '../../utils/api';
import { object, params } from '../../utils/mapper';

export interface Service {
    name: string;
    hostName: string;
    state?: {
        isActive: boolean;
        error?: string;
        stackTrace?: string;
        info?: string;
    },
    jsonOptions?: string;
}

const defaultHostList: HostList = {
    hosts: [],
    serviceCount: 0,
    activeServiceCount: 0,
    loading: false,
    auth: true
};

const initialState: HostList = defaultHostList;

export const getService = createAsyncThunk('hostList/getService', async (service: ServiceInfo) => 
    await api.get(`/services/${service.hostName}/${service.name}`));

export const reloadService = createAsyncThunk('hostList/reloadService', async (service: ServiceInfo) =>
    await api.get(`/services/reload/${service.hostName}/${service.name}`));

export const updateService = createAsyncThunk('hostList/updateService', async (service: SimpleServiceInfo) =>
    await api.put(`/services/${service.hostName}/${service.name}`, {
        jsonOptions: JSON.stringify(object(service.parameters))
    }));

export const deleteService = createAsyncThunk('hostList/deleteService', async (service: ServiceInfo) =>
    await api.delete(`/services/${service.hostName}/${service.name}`));

const setService = (state: HostList, payload: Service) => {
    const { name, hostName, jsonOptions } = payload;
    const isActive = payload.state?.isActive;
    
    let host = state.hosts.find(h => h.name === hostName);
    if (!host) {
        host = {
            name: hostName,
            services: [],
            activeServiceCount: 0,
            error: false
        };
        state.hosts.push(host);
    }

    let service = host.services.find(s => s.name === name);
    let index = -1;

    if (!service) {
        state.serviceCount += 1;
        if (isActive) {
            state.activeServiceCount += 1;
            host.activeServiceCount += 1;
        }
    } else {
        if (service.timeoutId) {
            clearTimeout(service.timeoutId);
            service.timeoutId = undefined;
        }

        if (isActive && !service.state?.isActive) {
            state.activeServiceCount += 1;
            host.activeServiceCount += 1;
        } else if (!isActive && service.state?.isActive) {
            state.activeServiceCount -= 1;
            host.activeServiceCount -= 1;
        }

        index = host.services.indexOf(service);
    }

    service = {
        name: name,
        hostName: hostName,
        state: !payload.state ? undefined : {
            isActive: payload.state.isActive,
            error: payload.state.error,
            stackTrace: payload.state.stackTrace
        },
        loading: false,
        updateError: payload.state?.info,
        parameters: {
            booleanParameters: [],
            stringParameters: [],
            listParameters: [],
            booleanMapParameters: [],
            stringMapParameters: []
        }
    };

    if (jsonOptions)
        service.parameters = params(JSON.parse(jsonOptions));

    index >= 0
        ? host.services[index] = service
        : host.services.push(service);
};

const remove = (state: HostList, payload: {
    name: string;
    hostName: string;
}) => {
    const { name, hostName } = payload;
    const host = state.hosts.find(h => h.name === hostName);
    if (host) {
        const service = host.services.find(s => s.name === name);
        if (service) {
            if (host.services.length === 1) {
                const index = state.hosts.indexOf(host);
                if (index >= 0) {
                    state.serviceCount -= 1;
                    if (service.state?.isActive)
                        state.activeServiceCount -= 1;
                        
                    state.hosts.splice(index, 1);
                }
            } else {
                const index = host.services.indexOf(service);
                if (index >= 0) {
                    state.serviceCount -= 1;
                    if (service.state?.isActive) {
                        state.activeServiceCount -= 1;
                        host.activeServiceCount -= 1;
                    }

                    host.services.splice(index, 1);
                }
            }
        }
    }
};

const pending = (state: HostList, action: any) => {
    const { name, hostName } = action.meta.arg;
    const service = state.hosts.find(h => h.name === hostName)?.services.find(s => s.name === name);
    if (service) {
        service.loading = true;
        service.updateError = undefined;
    }
};

const rejected = (state: HostList, action: any) => {
    const { name, hostName } = action.meta.arg;
    const service = state.hosts.find(h => h.name === hostName)?.services.find(s => s.name === name);
    if (service) {
        if (service.timeoutId) {
            clearTimeout(service.timeoutId);
            service.timeoutId = undefined;
        }
        service.loading = false;
        service.updateError = action.error.message;
    }

    if (action.error.code === '401')
        state.auth = false;
};

const hostListSlice = createSlice({
    name: 'hostList',
    initialState,
    reducers: {
        update(state, action: PayloadAction<Service>) {
            setService(state, action.payload)
        },
        updateServiceRange(state, action: PayloadAction<Service[]>) {
            action.payload.forEach(service => setService(state, service));
            state.loading = false;
            state.error = undefined;
        },
        removeService(state, action: PayloadAction<{
            name: string;
            hostName: string;
        }>) {
            remove(state, action.payload);
        },
        setTimeoutService(state, action: PayloadAction<{
            name: string;
            hostName: string;
            timeoutId: NodeJS.Timeout;
        }>) {
            const { name, hostName, timeoutId } = action.payload;
            const service = state.hosts.find(h => h.name === hostName)?.services.find(s => s.name === name);
            if (service) {
                service.timeoutId = timeoutId;
                service.loading = true;
            }
        },
        setLoading(state, action: PayloadAction<boolean>) {
            state.loading = action.payload;
        },
        setError(state, action: PayloadAction<string | undefined>) {
            state.error = action.payload;
        },
        authorized(state) {
            state.auth = true;
        }
    },
    extraReducers: (builder) => {
        builder.addCase(getService.fulfilled, (state, action) => setService(state, action.payload));
        builder.addCase(getService.rejected, (state, action) => rejected(state, action));
        builder.addCase(reloadService.pending, (state, action) => pending(state, action));
        builder.addCase(reloadService.rejected, (state, action) => rejected(state, action));
        builder.addCase(updateService.pending, (state, action) => pending(state, action));
        builder.addCase(updateService.rejected, (state, action) => rejected(state, action));
        builder.addCase(deleteService.pending, (state, action) => pending(state, action));
        builder.addCase(deleteService.rejected, (state, action) => rejected(state, action));
    }
});

export const {
    update,
    updateServiceRange,
    removeService,
    setTimeoutService,
    setLoading,
    setError,
    authorized
} = hostListSlice.actions;

export default hostListSlice.reducer;
