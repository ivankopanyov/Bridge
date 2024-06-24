import { FC, PropsWithChildren } from 'react';
import { Typography } from '@mui/material';
import './Text.scss'

interface TextProps {
    assignment?: 'description' | 'error';
    multiline?: boolean;
    large?: boolean;
    full?: boolean;
}
  
export const Text: FC<Readonly<PropsWithChildren<TextProps>>> = ({ assignment, multiline, large, full, children }) => {
    return (
        <Typography className={`text-base ${!full && 'text-hidden'} ${assignment === 'description' && 'text-secondary'} ${assignment === 'error' && 'text-fail'} ${!multiline && 'text-oneline'} ${large && 'text-large'}`}>
            { children }
        </Typography>
    );
};

export default Text;