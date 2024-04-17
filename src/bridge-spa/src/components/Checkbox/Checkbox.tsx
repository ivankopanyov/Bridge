import { FC } from "react";
import { IconButton } from "@mui/material";
import { Check, DoDisturb } from "@mui/icons-material";
import './Checkbox.scss';

interface CheckboxProps {
    value: boolean;
    setValue: (value: boolean) => void;
    disabled?: boolean;
    large?: boolean;
}

export const Checkbox: FC<Readonly<CheckboxProps>> = ({ value, setValue, disabled, large }) => {
    const iconClassName = `checkbox-icon ${!large && 'checkbox-icon-medium'}`;

    const onClick = () => setValue(!value);

    return (
        <IconButton 
            className={`checkbox ${!disabled && 'checkbox-enabled'} ${large && 'checkbox-large'}`}
            onClick={onClick}
            disabled={disabled}
        >
            {
                value
                    ? <Check className={iconClassName} />
                    : (disabled && <DoDisturb className={iconClassName} />)
            }
        </IconButton>
    );
};

export default Checkbox;