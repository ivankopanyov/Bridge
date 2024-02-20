import React from "react";
import { HttpClient } from "../services/useHttpClient";
import { ServiceViewModel } from "../viewModels/useServiceViewModel";
import Component from "./Component";
import Text from "./Text";
import Service from "../models/Service";
import OptionsProperty from "../models/OptionsProperty";
import ButtonProperty from "./ButtonProperty";
import Field from "./Field";
import ErrorView from "./ErrorView";
import ServiceDto from "../dto/ServiceDto";

interface ServiceViewProps {
    serviceViewModel: ServiceViewModel;
    httpClient: HttpClient;
    service: Service;
    successColor: string;
    failColor: string;
}

const ServiceView: React.FC<ServiceViewProps> = (props: ServiceViewProps) => {
    const margin: number = 20;

    const [disabled, setDisabled] = React.useState<boolean>(false);
    const [error, setError] = React.useState<string | undefined>(undefined);
  
    const setOptionsRequest = async () => await props.httpClient
        .update<ServiceDto>("hosts/" + props.service.hostName + "/" + props.service.name, {
            jsonOptions: !props.service.temp
                ? props.service.temp
                : JSON.stringify(Object.fromEntries(props.service.temp.map(p => [p.name, p.value])))
        })
        .then(data => {
            setDisabled(false);
            setError(undefined);
            props.serviceViewModel.updateService(data);
        })
        .catch(error => {
            setDisabled(false);
            setError(error.message ?? error.status);
        });
    
    return (
        <Component
            title={props.service.name}
            titleColor={props.service.state.isActive ? props.successColor : props.failColor}
            onResetClick={() => props.serviceViewModel.resetOptions(props.service.hostName, props.service.name)}>
            {(props.service.state.error || props.service.state.stackTrace) && <ErrorView
                error={props.service.state.error}
                stackTrace={props.service.state.stackTrace}
                failColor={props.failColor}
                margin={margin} /> }
            { props.service.temp && 
                <div 
                    style={{
                        marginTop: margin + "px"
                    }}>
                    { props.service.temp.map((property, index) => <Field 
                        key={index}
                        name={property.name}
                        value={property.value}
                        setValue={value => {
                            if (!props.service.temp)
                                return;

                            const options = [...props.service.temp];
                            const index = options.findIndex(p => p.name === property.name);
                            if (index >= 0) {
                                options[index] = {
                                    name: property.name,
                                    value: value
                                };
                                props.serviceViewModel.updateOptions(props.service.hostName, props.service.name, options);
                            }
                        }}
                        mb={margin}
                        disabled={disabled} />
                    )}
                    { error &&
                        <div style={{ width: "100%", marginTop: "10px", display: "flex", justifyContent: "center" }}>
                            <Text fontSize='12px' color='red'>
                                {error}
                            </Text>
                        </div> }
                    <ButtonProperty
                        label='Save and Restart'
                        onClick={async () => { 
                            setDisabled(true);
                            setError(undefined);
                            await setOptionsRequest();
                        }}
                        disabled={disabled} />
                </div> }
        </Component>
    );
};

export default ServiceView;