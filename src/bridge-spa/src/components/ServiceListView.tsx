import React from "react";
import { HttpClient } from "../services/useHttpClient";
import { ServiceViewModel } from "../viewModels/useServiceViewModel";
import Component from "./Component";
import Host from "../models/Host";
import HostView from "./HostView";

interface ServiceListViewProps {
    serviceViewModel: ServiceViewModel;
    httpClient: HttpClient;
}

const ServiceListView: React.FC<ServiceListViewProps> = (props: ServiceListViewProps) => {
    const successColor: string = "#a6ffbb";
    const failColor: string = "#ffa6a6";

    const [error, setError] = React.useState<string | null>("Load services");
    
    const getServices = async () => await props.httpClient.get<Host[]>("hosts")
        .then(async data => {
            setError(null);
            props.serviceViewModel.initServices(data);
        })
        .catch(async error => {
            setError(error.message ?? error.status);
            setTimeout(async () => await getServices(), 1000);
        });
    
    React.useEffect(() => { getServices(); }, []);

    return (
        <Component
            title={"Services (" + (props.serviceViewModel.all().flatMap(h => h.services).filter(s => s.state.isActive).length ?? 0) + " / " + (props.serviceViewModel.all().flatMap(h => h.services).length ?? 0) + ")"}
            titleColor={ props.serviceViewModel.all().flatMap(h => h.services).find(s => !s.state.isActive) ? failColor : successColor}>
            { error && <div>{error}</div> }
            { props.serviceViewModel.all().map((host, index) => <HostView
                key={index}
                serviceViewModel={props.serviceViewModel}
                httpClient={props.httpClient}
                host={host}
                successColor={successColor}
                failColor={failColor} />)}
        </Component>
    );
};

export default ServiceListView;