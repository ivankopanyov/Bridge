import { useEffect, FC, PropsWithChildren } from 'react';
import { Box } from '@mui/material';

interface TabProps {
    setTab: () => void;
}

export const Tab: FC<Readonly<PropsWithChildren<TabProps>>> = ({ setTab, children }) => {
    useEffect(() => { setTab(); }, []);
    
    return (<Box>{ children }</Box>);
};

export default Tab;