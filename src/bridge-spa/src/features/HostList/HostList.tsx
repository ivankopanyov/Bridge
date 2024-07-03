import { FC, useEffect } from 'react';
import { DisplaySettings } from '@mui/icons-material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { update, removeService, setError, updateServiceRange, setLoading } from './HostListStore';
import { useConnection } from '../../hooks';
import { api } from '../../utils/api';
import Host from '../Host/Host';
import Service from '../Service/Service';
import NavBar from '../../components/NavBar/NavBar';
import Error from '../../components/Error/Error';
import './HostList.scss';

const HostList: FC = () => {
    const dispatch = useAppDispatch();
    const hostList = useAppSelector(({ hostList }: RootState) => hostList);

    const connection = useConnection('/services', {
        invoke: () => {
            dispatch(setLoading(true));
            return ['Services', []];
        },
        callback: (running, _authError, message) => {
            dispatch(setLoading(!running));
            dispatch(setError(message));
        },
        auth: api.refresh,
        handlers: [
            ['Service', service => dispatch(update(service))],
            ['Services', services => dispatch(updateServiceRange(services))],
            ['RemoveService', service => dispatch(removeService(service))]
        ]
    });

    useEffect(() => {
        connection.start();
        return () => {
            connection.stop();
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