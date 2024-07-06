import { useState, FC } from "react";
import { IconButton, InputAdornment, OutlinedInput } from "@mui/material";
import { Visibility, VisibilityOff, Cancel } from "@mui/icons-material";
import "./InputText.scss";

interface InputTextProps {
    value: string;
    onChange: (value: string) => void;
    disabled?: boolean;
    password?: boolean;
}

export const InputText: FC<Readonly<InputTextProps>> = ({ value, onChange, disabled, password }) => {
    const [showPassword, setShowPassword] = useState(false);
    
    return (
        <OutlinedInput
            type={!password || showPassword ? 'text' : 'password'}
            value={value}
            onChange={e => onChange(e.target.value)}
            disabled={disabled}
            fullWidth
            endAdornment={
                (password || value.length > 0) &&
                    <InputAdornment className="input-text-input-adornment" position="end">
                        {
                            password &&
                                <IconButton onClick={() => setShowPassword(!showPassword)} edge="end">
                                    {showPassword ? <VisibilityOff className="input-text-icon" /> : <Visibility className="input-text-icon" />}
                                </IconButton>
                        }
                        {
                            value.length > 0 &&
                                <IconButton onClick={() => onChange('')} edge="end" >
                                    <Cancel className="input-text-icon" />
                                </IconButton>
                        }
                    </InputAdornment>
            }
        />
    );
};

export default InputText;