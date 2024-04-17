import { useEffect, useState, FC } from 'react';
import { Navigate, Route, Routes, useNavigate } from 'react-router-dom';
import * as signalR from '@microsoft/signalr';
import { BottomNavigation, BottomNavigationAction, Box } from '@mui/material';
import { MenuBook, DisplaySettings } from '@mui/icons-material';
import { useAppDispatch } from '../redux/hooks';
import useScreenSize from '../hooks/useScreenSize';
import { getHosts, removeHost, removeService, setStatus, update } from '../features/HostList/HostListStore';
import HostList from '../features/HostList/HostList';
import LogList from '../features/LogList/LogList';
import { Tab } from '../components';
import './App.scss';

const App: FC = () => {
    const dispatch = useAppDispatch();
    const screenSize = useScreenSize();
    const navigate = useNavigate();
    const [tab, setTab] = useState<number>(0);
    const tabClassName = `tab ${!screenSize.isMobile && 'tab-desktop'}`;

    const updateHosts = async () => {
        const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl('http://localhost:8080/update', {
                skipNegotiation: true,
                transport: signalR.HttpTransportType.WebSockets
            })
            .build();
        
        hubConnection.on('Update', (message) => dispatch(update(JSON.parse(message))));
        hubConnection.on('RemoveService', (message) => dispatch(removeService(JSON.parse(message))));
        hubConnection.on('RemoveHost', (message) => dispatch(removeHost(JSON.parse(message))));

        hubConnection.onclose(async (error) => {
            dispatch(setStatus({ 
                loading: true, 
                error: error?.message
            }))
            await loadHosts();
        });
    
        await hubConnection.start()
            .then(() => dispatch(setStatus({ 
                loading: false
            })))
            .catch(error => {
                dispatch(setStatus({ 
                    loading: true, 
                    error: error?.message
                }));
                setTimeout(updateHosts, 1000);
            });
    };

    const loadHosts = async () => {
        const result = await dispatch(getHosts());
        if (result.meta.requestStatus !== 'fulfilled') {
            setTimeout(loadHosts, 1000);
        } else {
            await updateHosts();
        }
    };

    const switchTab = (tabIndex: number) => {
        setTab(tabIndex);
        switch (tabIndex) {
            case 0:
                navigate('services');
                break;

            case 1:
                navigate('logs');
                break;
        }
    };
    
    useEffect(() => { loadHosts(); }, []);
    
    return (
        <Box className={ screenSize.isMobile ? 'tab-bar-container-mobile' : 'tab-bar-container-desktop' }>
            <Routes>
                <Route path="services" element={
                    <Tab setTab={() => setTab(0)}>
                        <HostList />
                    </Tab>
                } />
                <Route path="logs" element={
                    <Tab setTab={() => setTab(1)}>
                        <LogList />
                    </Tab>
                } />
                <Route path="*" element={<Navigate to="services" replace={true} />} /> 
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
                    icon={<DisplaySettings className="tab-bar-icon" />}
                    label={ !screenSize.isMobile && 'Services' }
                />
                <BottomNavigationAction className={tabClassName}
                    icon={<MenuBook className="tab-bar-icon" />}
                    label={ !screenSize.isMobile && 'Logs' }
                />
            </BottomNavigation>
        </Box>
    );
}

export default App;
