import { FC } from "react";
import { IconButton } from "@mui/material";
import { Check } from "@mui/icons-material";
import './Checkbox.scss';

interface CheckboxProps {
    value: boolean;
    setValue: (value: boolean) => void;
    disabled?: boolean;
    large?: boolean;
}

export const Checkbox: FC<Readonly<CheckboxProps>> = ({ value, setValue, disabled, large }) => {

    const onClick = () => setValue(!value);

    return (
        <div className={`checkbox-container ${large ? 'checkbox-container-large' : 'checkbox-container-medium'}`}>
            <IconButton 
                className={`${large ? 'checkbox-large' : 'checkbox-medium'}`}
                onClick={onClick}
                disabled={disabled}
            >
                {
                    value &&
                        <Check className={`checkbox-icon ${!large && 'checkbox-icon-medium'}`} />
                }
            </IconButton>
        </div>
    );
};

export default Checkbox;