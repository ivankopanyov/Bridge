import React from "react";
import { HttpClient } from "../services/useHttpClient";
import { ServiceViewModel } from "../viewModels/useServiceViewModel";
import Component from "./Component";
import Host from "../models/Host";
import ServiceView from "./ServiceView";

interface HostViewProps {
    serviceViewModel: ServiceViewModel;
    httpClient: HttpClient;
    host: Host;
    successColor: string;
    failColor: string;
}

const HostView: React.FC<HostViewProps> = (props: HostViewProps) => {
    return (
        <Component
            title={props.host.name + " (" + props.host.services.filter(s => s.state.isActive).length + " / " + props.host.services.length + ")"}
            titleColor={props.host.services.find(service => !service.state.isActive) ? props.failColor : props.successColor}
            contentColor='gray'>
            { props.host.services.map((service, index) => <ServiceView
                key={index}
                serviceViewModel={props.serviceViewModel}
                httpClient={props.httpClient}
                service={service}
                successColor={props.successColor}
                failColor={props.failColor} /> )}
        </Component>
    );
};

export default HostView;