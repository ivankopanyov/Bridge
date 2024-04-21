import { FC, PropsWithChildren } from 'react';
import { Typography } from '@mui/material';
import './Text.scss'

interface TextProps {
    secondary?: boolean;
    multiline?: boolean;
    large?: boolean;
    full?: boolean;
}
  
export const Text: FC<Readonly<PropsWithChildren<TextProps>>> = ({ secondary, multiline, large, full, children }) => {
    return (
        <Typography className={`text-base ${!full && 'text-hidden'} ${secondary && 'text-secondary'} ${!multiline && 'text-oneline'} ${large && 'text-large'}`}>
            { children }
        </Typography>
    );
};

export default Text;