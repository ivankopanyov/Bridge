import { FC, useEffect } from 'react';
import { DisplaySettings } from '@mui/icons-material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { changeService, getServices, removeService, setError } from './HostListStore';
import { useWebSocket } from '../../hooks';
import Host from '../Host/Host';
import Service from '../Service/Service';
import NavBar from '../../components/NavBar/NavBar';
import Error from '../../components/Error/Error';
import './HostList.scss';

const HostList: FC = () => {
    const dispatch = useAppDispatch();
    const hostList = useAppSelector(({ hostList }: RootState) => hostList);

    const load = async () => {
        const result = await dispatch(getServices());
        return result.meta.requestStatus === 'fulfilled';
    };

    const socket = useWebSocket('/services', load, error => dispatch(setError(error)), [{
        methodName: 'Service',
        newMethod: (message) => dispatch(changeService(JSON.parse(message)))
    }, {
        methodName: 'RemoveService',
        newMethod: (message) => dispatch(removeService(JSON.parse(message)))
    }]);

    useEffect(() => {
        socket.start();
        return () => {
            socket.stop();
        };
    }, []);

    return (
        <NavBar
            title={`Services (${hostList.activeServiceCount}/${hostList.serviceCount})`}
            icon={<DisplaySettings className="host-list-icon" />}
            loading={hostList.loading}
        >
            { hostList.error && <Error error={hostList.error} /> }
            { 
                hostList.hosts.length > 0 && hostList.hosts.map(host => host.services.length === 1
                    ? <Service key={host.name} service={host.services[0]} showHostName />
                    : <Host key={host.name} host={host} />) 
            }
        </NavBar>
    );
};

export default HostList;