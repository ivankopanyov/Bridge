import { PayloadAction, createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { HostList, KeyValue, ServiceInfo } from './data';
import { api } from '../../utils/api';

interface Service {
    name: string;
    hostName: string;
    state: {
        isActive: boolean;
        error?: string;
        stackTrace?: string;
    },
    jsonOptions?: string;
}

const defaultHostList: HostList = {
    hosts: [],
    serviceCount: 0,
    activeServiceCount: 0,
    loading: false
};

const initialState: HostList = defaultHostList;

const getType = (value: any): 'boolean' | 'string' | 'array' | 'map' => {
    const type = typeof value;
    if (type === 'boolean')
        return 'boolean';
    if (type === 'object')
        return Array.isArray(value) ? 'array' : 'map';
    return 'string';
}

export const getHosts = createAsyncThunk('hostList/getHosts', async () => {
        const [error, response] = await api.get('/hosts');

        if (error)
            throw new Error(error);
        
        return response;
    }
);

export const updateService = createAsyncThunk('hostList/updateService', async (service: ServiceInfo) => {
        const [error, response] = await api.put(`/hosts/${service.hostName}/${service.name}`, {
            jsonOptions: JSON.stringify(Object.fromEntries([
                ...service.booleanParameters.map(p => [p.name, p.value]),
                ...service.stringParameters.map(p => [p.name, p.value]),
                ...service.listParameters.map(p => [p.name, p.value]),
                ...service.booleanMapParameters.map(p => [p.name, Object.fromEntries(p.value.map(i => [i.key, i.value]))]),
                ...service.stringMapParameters.map(p => [p.name, Object.fromEntries(p.value.map(i => [i.key, i.value]))])
            ]))
        });

        if (error)
            throw new Error(error);
        
        return response;
    }
);

const setService = (state: HostList, payload: Service) => {
    const { name, hostName, jsonOptions} = payload;
    const { isActive, error, stackTrace } = payload.state;
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
    if (!service) {
        state.serviceCount += 1;
        if (isActive) {
            state.activeServiceCount += 1;
            host.activeServiceCount += 1;
        }

        service = {
            name: name,
            hostName: hostName,
            isActive: isActive,
            error: error,
            stackTrace: stackTrace,
            loading: false,
            updateError: undefined,
            booleanParameters: [],
            stringParameters: [],
            listParameters: [],
            booleanMapParameters: [],
            stringMapParameters: []
        };
        host.services.push(service);
    } else {
        if (isActive && !service.isActive) {
            state.activeServiceCount += 1;
            host.activeServiceCount += 1;
        } else if (!isActive && service.isActive) {
            state.activeServiceCount -= 1;
            host.activeServiceCount -= 1;
        }

        service.name = name;
        service.hostName = hostName;
        service.isActive = isActive;
        service.error = error;
        service.stackTrace = stackTrace;
        service.loading = false;
        service.updateError = undefined;
        service.booleanParameters = [];
        service.stringParameters = [];
        service.listParameters = [];
        service.booleanMapParameters = [];
        service.stringMapParameters = [];
    }

    if (!jsonOptions)
        return;

    const options = JSON.parse(jsonOptions);
    const values = Object.values<any>(options);
    Object.keys(options).forEach((key, index) => { 
        switch (getType(values[index])) {
            case 'boolean':
                const booleanValue = Boolean(values[index]);
                service?.booleanParameters?.push({
                    name: key,
                    value: booleanValue
                });
                break;

            case 'string':
                const stringValue = String(values[index]);
                service?.stringParameters?.push({
                    name: key,
                    value: stringValue
                });
                break;
                
            case 'array':
                const listValue = [...values[index]].map(i => String(i));
                service?.listParameters?.push({
                    name: key,
                    value: listValue
                });
                break;
                
            case 'map':
                const mapValues = Object.values<any>(values[index]);
                if (mapValues.length > 0 && getType(mapValues[0]) === 'boolean') {
                    service?.booleanMapParameters.push({
                        name: key,
                        value: Object.keys(values[index]).map((k, i) => { return {
                            key: k,
                            value: Boolean(mapValues[i])
                        }})
                    });
                } else {
                    service?.stringMapParameters.push({
                        name: key,
                        value: Object.keys(values[index]).map((k, i) => { return {
                            key: k,
                            value: String(mapValues[i])
                        }})
                    });
                }
                break;
        }
    });
};

const hostListSlice = createSlice({
    name: 'hostList',
    initialState,
    reducers: {
        update(state, action: PayloadAction<Service>) {
            setService(state, action.payload);
        },
        removeService(state, action: PayloadAction<{
            name: string;
            hostName: string;
        }>) {
            const { name, hostName } = action.payload;
            const host = state.hosts.find(h => h.name === hostName);
            if (host) {
                const service = host.services.find(s => s.name === name);
                if (service) {
                    const index = host.services.indexOf(service);
                    if (index >= 0) {
                        host.services.splice(index, 1);
                    }
                }
            }
        },
        removeHost(state, action: PayloadAction<{
            name: string;
        }>) {
            const { name } = action.payload;
            const host = state.hosts.find(h => h.name === name);
            if (host) {
                const index = state.hosts.indexOf(host);
                if (index >= 0) {
                    state.hosts.splice(index, 1);
                }
            }
        },
        setStatus(state, action: PayloadAction<{
            loading: boolean;
            error?: string;
        }>) {
            const { loading, error } = action.payload;
            state.loading = loading;
            state.error = error;
        }
    },
    extraReducers: (builder) => {
        builder.addCase(getHosts.pending, (state) => {
            state.loading = true;
        });
        builder.addCase(getHosts.fulfilled, (state, action: PayloadAction<{
            name: string;
            services: Service[]
        }[]>) => action.payload.flatMap(h => h.services).forEach(service => setService(state, service)));
        builder.addCase(getHosts.rejected, (state, action) => {
            state.error = action.error.message;
        });
        builder.addCase(updateService.pending, (state, action) => {
            const { name, hostName } = action.meta.arg;
            const service = state.hosts.find(h => h.name === hostName)?.services.find(s => s.name === name);
            if (service) {
                service.loading = true;
                service.updateError = undefined;
            }
        });
        builder.addCase(updateService.fulfilled, (state, action: PayloadAction<Service>) => setService(state, action.payload));
        builder.addCase(updateService.rejected, (state, action) => {
            const { name, hostName } = action.meta.arg;
            const service = state.hosts.find(h => h.name === hostName)?.services.find(s => s.name === name);
            if (service) {
                service.loading = false;
                service.updateError = 'Error';
            }
        });
    }
});

export const {
    update,
    removeService,
    removeHost,
    setStatus
} = hostListSlice.actions;

export default hostListSlice.reducer;
