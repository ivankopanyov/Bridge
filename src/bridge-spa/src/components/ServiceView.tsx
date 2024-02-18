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

interface ServiceViewProps {
    serviceViewModel: ServiceViewModel;
    httpClient: HttpClient;
    service: Service;
    successColor: string;
    failColor: string;
}

const ServiceView: React.FC<ServiceViewProps> = (props: ServiceViewProps) => {
    const margin: number = 20;

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

    const [disabled, setDisabled] = React.useState<boolean>(false);
    const [error, setError] = React.useState<string | undefined>(undefined);
    const [options, setOptions] = React.useState<OptionsProperty[] | undefined>(getOptionsProperties(props.service.jsonOptions));

    const getOptions = () => {
        if (!options)
            return options;
        const map = new Map<string, any>();
        options.forEach(property => map.set(property.name, property.value));
        return Object.fromEntries(map.entries());
    };
  
    const setOptionsRequest = async () => await props.httpClient
        .update<Service>("hosts/" + props.service.hostName + "/" + props.service.name, {
            jsonOptions: JSON.stringify(getOptions())
        })
        .then(data => {
            setDisabled(false);
            setError(undefined);
            props.serviceViewModel.setService(data);
            setOptions(getOptionsProperties(data.jsonOptions));
        })
        .catch(error => {
            setDisabled(false);
            setError(error.message ?? error.status);
        });
    
    return (
        <Component
            title={props.service.name}
            titleColor={props.service.state.isActive ? props.successColor : props.failColor}
            onResetClick={() => setOptions(getOptionsProperties(props.service.jsonOptions))}>
            {(props.service.state.error || props.service.state.stackTrace) && <ErrorView
                error={props.service.state.error}
                stackTrace={props.service.state.stackTrace}
                failColor={props.failColor}
                margin={margin} /> }
            { options && 
                <div 
                    style={{
                        marginTop: margin + "px"
                    }}>
                    { options.map((property, index) => <Field 
                        key={index}
                        name={property.name}
                        value={property.value}
                        setValue={value => {
                            const newOptions = [...options];
                            const newValue: OptionsProperty = {
                                name: property.name,
                                value: value
                            };

                            const index = newOptions.findIndex(p => p.name === property.name);
                            index >= 0 ? newOptions[index] = newValue : newOptions.push(newValue);
                            setOptions(newOptions);
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