import { IconButton } from "@mui/material";
import Component from "./Component";
import MarginProps from "./MarginProps";
import DeleteForeverIcon from '@mui/icons-material/DeleteForever';
import Field from "./Field";
import React from "react";

interface ArrayPropertyProps extends MarginProps {
    title: string;
    value: any[];
    setValue: (value: any[]) => void
    disabled?: boolean;
}
  
const ArrayProperty: React.FC<ArrayPropertyProps> = (props: ArrayPropertyProps) => {
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
                newValue.push("");
                props.setValue(newValue);
            }}
            disabled={props.disabled}>
            {props.value.map((v, index) => 
            <div 
                key={index}
                style={{
                    width: "100%",
                    display: "flex", 
                    alignItems: "center",
                    marginTop: props.mb ? props.mb + "px" : props.mb
                }}>
                <Field
                    name=""
                    value={v}
                    setValue={val => {
                        const newValue = [...props.value];
                        newValue[index] = val;
                        props.setValue(newValue);
                    }}
                    disabled={props.disabled} />
                <IconButton
                    onClick={() => {
                        const newValue = [...props.value];
                        newValue.splice(index, 1);
                        props.setValue(newValue);
                    }}
                    disabled={props.disabled}>
                    <DeleteForeverIcon />
                </IconButton>
            </div>)}
        </Component>
    );
};

export default ArrayProperty;