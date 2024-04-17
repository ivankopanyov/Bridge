import { FC, PropsWithChildren } from 'react';
import { Typography } from '@mui/material';
import './Text.scss'

interface TextProps {
    secondary?: boolean;
    multiline?: boolean;
    large?: boolean;
}
  
export const Text: FC<Readonly<PropsWithChildren<TextProps>>> = ({ secondary, multiline, large, children }) => {
    return (
        <Typography className={`text-base ${secondary && 'text-secondary'} ${!multiline && 'text-oneline'} ${large && 'text-large'}`}>
            { children }
        </Typography>
    );
};

export default Text;