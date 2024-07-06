import { useState, FC } from 'react';
import { Navigate, Route, Routes, useNavigate } from 'react-router-dom';
import { BottomNavigation, BottomNavigationAction } from '@mui/material';
import { MenuBook, DisplaySettings, FormatListBulleted } from '@mui/icons-material';
import { Tab } from '../../components';
import useScreenSize from '../../hooks/useScreenSize';
import HostList from '../HostList/HostList';
import Environment from '../Environment/Environment';
import LogList from '../LogList/LogList';
import './TabBar.scss';

const TabBar: FC = () => {
    const screenSize = useScreenSize();
    const navigate = useNavigate();
    const [tab, setTab] = useState<number>(0);
    const tabClassName = `tab ${!screenSize.isMobile && 'tab-desktop'}`;

    const switchTab = (tabIndex: number) => {
        setTab(tabIndex);
        switch (tabIndex) {
            case 0:
                navigate('logs');
                break;

            case 1:
                navigate('services');
                break;

            case 2:
                navigate('environment');
                break;
        }
    };
    
    return (
        <div className={ screenSize.isMobile ? 'tab-bar-container-mobile' : 'tab-bar-container-desktop' }>
            <Routes>
                <Route
                    path="logs"
                    element={<Tab setTab={() => setTab(0)}><LogList /></Tab>}
                />
                <Route
                    path="services"
                    element={<Tab setTab={() => setTab(1)}><HostList /></Tab>}
                />
                <Route
                    path="environment"
                    element={<Tab setTab={() => setTab(2)}><Environment /></Tab>}
                />
                <Route path="*" element={<Navigate to="logs" replace={true} />} /> 
            </Routes>
            <BottomNavigation className={`tab-bar ${screenSize.isMobile ? 'tab-bar-mobile' : 'tab-bar-desktop'}`}
                showLabels={!screenSize.isMobile}
                sx={{
                    width: screenSize.isMobile ? screenSize.width : undefined,
                    height: screenSize.isMobile ? undefined : screenSize.height
                }}
                value={tab}
                onChange={(_e, value) => switchTab(value)}
            >
                <BottomNavigationAction className={tabClassName}
                    icon={<MenuBook className="tab-bar-icon" />}
                    label={ !screenSize.isMobile && 'Logs' }
                />
                <BottomNavigationAction className={tabClassName}
                    icon={<DisplaySettings className="tab-bar-icon" />}
                    label={ !screenSize.isMobile && 'Services' }
                />
                <BottomNavigationAction className={tabClassName}
                    icon={<FormatListBulleted className="tab-bar-icon" />}
                    label={ !screenSize.isMobile && 'Environment' }
                />
            </BottomNavigation>
        </div>
    );
}

export default TabBar;
