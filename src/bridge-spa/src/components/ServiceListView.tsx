import React from "react";
import { HttpClient } from "../services/useHttpClient";
import { ServiceViewModel } from "../viewModels/useServiceViewModel";
import Component from "./Component";
import HostView from "./HostView";
import { useSignalR } from "../services/useSignalR";
import HostDto from "../dto/HostDto";

interface ServiceListViewProps {
    serviceViewModel: ServiceViewModel;
    httpClient: HttpClient;
    error?: string;
    setError: (value?: string) => void;
}

const ServiceListView: React.FC<ServiceListViewProps> = (props: ServiceListViewProps) => {
    const successColor: string = "#a6ffbb";
    const failColor: string = "#ffa6a6";
    
    const getServices = async () => await props.httpClient.get<HostDto[]>("hosts")
        .then(async data => {
            props.setError(undefined);
            props.serviceViewModel.updateHostRange(data);
        })
        .catch(async error => {
            props.setError(error.message ?? error.status);
            setTimeout(async () => await getServices(), 1000);
        });
        
    const signalR = useSignalR("http://localhost:8080",
        props.serviceViewModel,
        getServices,
        props.setError);
    
    React.useEffect(() => { signalR.connect(); }, []);

    return (
        <Component
            title={"Services (" + (props.serviceViewModel.all().flatMap(h => h.services).filter(s => s.state.isActive).length ?? 0) + " / " + (props.serviceViewModel.all().flatMap(h => h.services).length ?? 0) + ")"}
            titleColor={ props.serviceViewModel.all().flatMap(h => h.services).find(s => !s.state.isActive) ? failColor : successColor}>
            { props.serviceViewModel.all().map(host => <HostView
                key={host.name}
                serviceViewModel={props.serviceViewModel}
                httpClient={props.httpClient}
                host={host}
                successColor={successColor}
                failColor={failColor} />)}
        </Component>
    );
};

export default ServiceListView;