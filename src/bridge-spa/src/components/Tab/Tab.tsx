import { useEffect, FC, PropsWithChildren } from 'react';

interface TabProps {
    setTab: () => void;
}

export const Tab: FC<Readonly<PropsWithChildren<TabProps>>> = ({ setTab, children }) => {
    useEffect(() => { setTab(); }, []);
    
    return (<div>{ children }</div>);
};

export default Tab;