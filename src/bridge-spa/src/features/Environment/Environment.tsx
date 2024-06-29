import { FC, useEffect } from 'react';
import { FormatListBulleted } from '@mui/icons-material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { updateEnvironment, changeEnvironment, setLoading, setError } from './EnvironmentStore';
import { Parameters } from '../ParameterList/data';
import { useConnection } from '../../hooks';
import { api } from '../../utils/api';
import NavBar from '../../components/NavBar/NavBar';
import ParameterList from '../ParameterList/ParameterList';
import './Environment.scss';

const Environment: FC = () => {
    const dispatch = useAppDispatch();
    const environment = useAppSelector(({ environment }: RootState) => environment);
    
    const connection = useConnection('/environment', {
        invoke: () => {
            dispatch(setLoading(true));
            return ['Environment', []];
        },
        callback: (running, _authError, message) => {
            dispatch(setLoading(!running));
            dispatch(setError(message));
        },
        auth: api.refresh,
        handlers: [['Environment', environment => dispatch(changeEnvironment(environment))]]
    });
    
    useEffect(() => {
        connection.start();
        return () => {
            connection.stop();
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