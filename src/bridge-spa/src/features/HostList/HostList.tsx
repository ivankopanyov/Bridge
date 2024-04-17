import { FC } from 'react';
import { Box, CircularProgress } from '@mui/material';
import { DisplaySettings } from '@mui/icons-material';
import { useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import Host from '../Host/Host';
import NavBar from '../../components/NavBar/NavBar';
import './HostList.scss';

const HostList: FC = () => {
    const hostList = useAppSelector(({ hostList }: RootState) => hostList);

    return (
        <NavBar
            title={`Services (${hostList.activeServiceCount}/${hostList.serviceCount})`}
            icon={ 
                hostList.loading 
                    ? <CircularProgress className="host-list-progress" />
                    : <DisplaySettings className="host-list-icon" />
            }
        >
            <Box className="host-list-page">
                <Box className="host-list-content">
                    { hostList.hosts.length > 0 && hostList.hosts.map(host => <Host key={host.name} host={host} />) }
                </Box>
            </Box>
        </NavBar>
    );
};

export default HostList;