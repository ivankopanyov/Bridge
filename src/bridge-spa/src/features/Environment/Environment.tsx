import { FC, useEffect, useState } from 'react';
import { FormatListBulleted } from '@mui/icons-material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { updateEnvironment, changeEnvironment, setLoading, setError, authorized } from './EnvironmentStore';
import { Parameters } from '../ParameterList/data';
import { useConnection } from '../../hooks';
import { api } from '../../utils/api';
import { unauthorized } from '../../App/AppStore';
import NavBar from '../NavBar/NavBar';
import ParameterList from '../ParameterList/ParameterList';
import './Environment.scss';

const Environment: FC = () => {
    const dispatch = useAppDispatch();
    const app = useAppSelector(({ app }: RootState) => app);
    const environment = useAppSelector(({ environment }: RootState) => environment);
    const [modifiedParameters, setModifiedParameters] = useState(environment.parameters);
    
    const connection = useConnection('/environment', {
        invoke: () => {
            dispatch(setLoading(true));
            return ['Environment', []];
        },
        callback: (running, authError, message) => {
            if (authError) {
                dispatch(unauthorized());
            } else {
                dispatch(setLoading(!running));
                dispatch(setError(message));
            }
        },
        auth: api.refresh,
        handlers: [['Environment', env => dispatch(changeEnvironment(JSON.parse(env)))]]
    });
    
    useEffect(() => {
        connection.start();
        return () => {
            connection.stop();
        };
    }, []);

    useEffect(() => {
        setModifiedParameters(environment.parameters);
    }, [environment.parameters]);

    useEffect(() => {
        if (!environment.auth) {
            dispatch(authorized());
            dispatch(unauthorized());
        }
    }, [environment.auth]);
    
    const onSaveClick = async (parameters: Parameters) => {
        await dispatch(updateEnvironment(parameters));
    };

    return (
        <NavBar
            title="Environment" 
            icon={<FormatListBulleted className="environment-icon" />}
            loading={environment.loading}
        >
            <ParameterList
                parameters={environment.parameters}
                modifiedParameters={modifiedParameters}
                disable={environment.loading}
                error={environment.error}
                setModifiedParameters={setModifiedParameters}
                onSave={onSaveClick}
            />
        </NavBar>
    );
};

export default Environment;