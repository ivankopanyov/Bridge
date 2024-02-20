import React from "react";
import MarginProps from "./MarginProps";
import Text from "./Text";
import { Checkbox } from "@mui/material";

interface CheckboxPropertyProps extends MarginProps {
    label: string;
    checked: boolean;
    onChange: (checked: boolean) => void;
    disabled?: boolean;
}
  
const CheckboxProperty: React.FC<CheckboxPropertyProps> = (props: CheckboxPropertyProps) => {
    return (
        <div style={{
                display: 'flex',
                marginTop: props.mt ? props.mt + "px" : props.mt,
                marginBottom: props.mb ? props.mb + "px" : props.mb,
                marginLeft: props.ml ? props.ml + "px" : props.ml,
                marginRight: props.mr ? props.mr + "px" : props.mr
            }}>
            { props.label.length > 0 && <Text short>
                {props.label}
            </Text> }
            <Checkbox
                checked={props.checked}
                onChange={(_e, c) => props.onChange(c)}
                disabled={props.disabled} />
        </div>
    );
};

export default CheckboxProperty;