import React from "react";
import MarginProps from "./MarginProps";
import { TextField } from "@mui/material";

interface InputPropertyProps extends MarginProps {
    label: string;
    value: string;
    onChange: (value: string) => void;
    disabled?: boolean;
}
  
const InputProperty: React.FC<InputPropertyProps> = (props: InputPropertyProps) => {
    return (
        <TextField
            id="outlined-required"
            label={props.label}
            value={props.value}
            onChange={e => props.onChange(e.target.value)}
            sx={{
                mt: props.mt ? props.mt + "px" : props.mt,
                mb: props.mb ? props.mb + "px" : props.mb,
                ml: props.ml ? props.ml + "px" : props.ml,
                mr: props.mr ? props.mr + "px" : props.mr
            }}
            fullWidth
            disabled={props.disabled}
        />
    );
};

export default InputProperty;