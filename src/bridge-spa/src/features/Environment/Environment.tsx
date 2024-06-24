import { FC, useEffect } from 'react';
import { FormatListBulleted } from '@mui/icons-material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { getEnvironment, updateEnvironment, changeEnvironment, setError } from './EnvironmentStore';
import { Parameters } from '../ParameterList/data';
import { useWebSocket } from '../../hooks';
import NavBar from '../../components/NavBar/NavBar';
import ParameterList from '../ParameterList/ParameterList';
import './Environment.scss';

const Environment: FC = () => {
    const dispatch = useAppDispatch();
    const environment = useAppSelector(({ environment }: RootState) => environment);

    const load = async () => {
        const result = await dispatch(getEnvironment());
        return result.meta.requestStatus === 'fulfilled';
    };

    const socket = useWebSocket('/environment', load, error => dispatch(setError(error)), [{
        methodName: 'Environment',
        newMethod: (message) => dispatch(changeEnvironment(JSON.parse(message)))
    }]);
    
    useEffect(() => {
        socket.start();
        return () => {
            socket.stop();
        };
    }, []);
    
    const onSaveClick = async (parameters: Parameters) => {
        const result = await dispatch(updateEnvironment(parameters));
        return result.meta.requestStatus !== 'fulfilled' ? environment.parameters : undefined;
    }

    return (
        <NavBar
            title="Environment" 
            icon={<FormatListBulleted className="environment-icon" />}
            loading={environment.loading}
        >
            <ParameterList
                parameters={environment.parameters}
                disable={environment.loading}
                error={environment.error}
                onSave={onSaveClick}
            />
        </NavBar>
    );
};

export default Environment;