import { services, init, set} from "../features/serviceSlice";
import { useAppSelector, useAppDispatch } from '../redux/hooks';
import Service from "../models/Service";
import Host from "../models/Host";

export interface ServiceViewModel {
    all: () => Host[];
    initServices: (value: Host[]) => void;
    setService: (service: Service) => void;
}

export const useServiceViewModel = (): ServiceViewModel => {
    const serviceList = useAppSelector(services);
    const dispatch = useAppDispatch();

    const all = (): Host[] => serviceList;
    
    const initServices = (value: Host[]) => {
        dispatch(init(value));
    };

    const setService = (service: Service) => {
        dispatch(set(service));
    };

    return {
        all,
        initServices,
        setService
    };
}