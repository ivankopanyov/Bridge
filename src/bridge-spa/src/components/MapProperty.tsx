import { IconButton } from "@mui/material";
import Component from "./Component";
import Field from "./Field";
import InputProperty from "./InputProperty";
import MarginProps from "./MarginProps";
import DeleteForeverIcon from '@mui/icons-material/DeleteForever';
import React from "react";
import OptionsProperty from "../models/OptionsProperty";

interface MapPropertyProps extends MarginProps {
    title: string;
    value: OptionsProperty[];
    setValue: (value: OptionsProperty[]) => void;
    disabled?: boolean;
}
  
const MapProperty: React.FC<MapPropertyProps> = (props: MapPropertyProps) => {
    return (
        <Component
            title={props.title}
            titleColor="lightgray"
            mt={props.mt}
            mb={props.mb}
            ml={props.ml}
            mr={props.mr}
            onAddClick={() => {
                const newValue = [...props.value];
                newValue.push({
                    name: "",
                    value: ""
                });
                props.setValue(newValue);
            }}
            disabled={props.disabled}>
            {props.value.map((property, index) => {
            return <div 
                key={index} 
                style={{ 
                    display: "flex", 
                    alignItems: "center",
                    marginTop: props.mb ? props.mb + "px" : props.mb
                }}>
                <InputProperty
                    label="Key"
                    value={property.name}
                    onChange={text => {
                        const newValue = [...props.value];
                        newValue[index] = {
                            name: text,
                            value: property.value
                        };
                        props.setValue(newValue);
                    }}
                    mr={10}
                    disabled={props.disabled} />
                <Field
                    name="Value"
                    value={property.value}
                    setValue={newValue => {
                        const val = [...props.value];
                        val[index] = {
                            name: property.name,
                            value: newValue
                        };
                        props.setValue(val);
                    }}
                    ml={10}
                    disabled={props.disabled} />
                <IconButton
                    sx={{
                        ml: "10px"
                    }}
                    onClick={() => {
                        const newValue = [...props.value];
                        newValue.splice(index, 1);
                        props.setValue(newValue);
                    }}
                    disabled={props.disabled}>
                    <DeleteForeverIcon />
                </IconButton>
            </div>})}
        </Component>
    );
};

export default MapProperty;