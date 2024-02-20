import { services, set, setRange, setOptions, reset, remove, removeRange} from "../features/serviceSlice";
import { useAppSelector, useAppDispatch } from '../redux/hooks';
import Host from "../models/Host";
import HostDto from "../dto/HostDto";
import RemoveServiceDto from "../dto/RemoveServiceDto";
import RemoveHostDto from "../dto/RemoveHostDto";
import ServiceDto from "../dto/ServiceDto";
import OptionsProperty from "../models/OptionsProperty";

export interface ServiceViewModel {
    all: () => Host[];
    updateService: (service: ServiceDto) => void;
    updateHostRange: (hosts: HostDto[]) => void;
    updateOptions: (hostName: string, serviceName: string, options: OptionsProperty[]) => void;
    resetOptions: (hostName: string, serviceName: string) => void;
    removeService: (service: RemoveServiceDto) => void;
    removeHost: (host: RemoveHostDto) => void;
}

export const useServiceViewModel = (): ServiceViewModel => {
    const serviceList = useAppSelector(services);
    const dispatch = useAppDispatch();

    const all = (): Host[] => serviceList;

    const updateService = (service: ServiceDto) => {
        const options = getOptionsProperties(service.jsonOptions);
        dispatch(set({
            name: service.name,
            hostName: service.hostName,
            state: service.state,
            options: options,
            temp: options ? [...options] : undefined
        }))
    }

    const updateHostRange = (hosts: HostDto[]) => {
        dispatch(setRange(hosts.map(host => { return {
            name: host.name,
            services: host.services.map(service => {
                const options = getOptionsProperties(service.jsonOptions);
                return {
                    name: service.name,
                    hostName: service.hostName,
                    state: service.state,
                    options: options,
                    temp: options ? [...options] : undefined
                }
            })
        }})));
    }
    
    const updateOptions = (hostName: string, serviceName: string, options: OptionsProperty[]) => {
        dispatch(setOptions({
            hostName: hostName,
            serviceName: serviceName,
            options: options
        }))
    }
    
    const resetOptions = (hostName: string, serviceName: string) => {
        dispatch(reset({
            hostName: hostName,
            serviceName: serviceName
        }))
    }
    
    const removeService = (service: RemoveServiceDto) => {
        dispatch(remove(service));
    };

    const removeHost = (host: RemoveHostDto) => {
        dispatch(removeRange(host));
    };

    const getOptionsProperties = (jsonOptions: string | undefined): OptionsProperty[] | undefined => {
        if (!jsonOptions)
            return undefined;

        try {
            const options = JSON.parse(jsonOptions);
            const values = Object.values<any>(options);
            return Object.keys(options).map((key, index) => { return {
                name: key,
                value: values[index]
            }});
        } catch {
            return undefined;
        }
    };

    return {
        all,
        updateService,
        updateHostRange,
        updateOptions,
        resetOptions,
        removeService,
        removeHost
    };
}