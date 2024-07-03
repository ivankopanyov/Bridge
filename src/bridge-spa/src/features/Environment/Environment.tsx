import { FC, useEffect, useState } from 'react';
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
    const [trigger, setTrigger] = useState<boolean | undefined>();
    const [modifiedParameters, setModifiedParameters] = useState(environment.parameters);
    
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
        handlers: [['Environment', env => {
            dispatch(changeEnvironment(JSON.parse(env)));
            if (trigger === undefined)
                setTrigger(!trigger);
        }]]
    });
    
    useEffect(() => {
        connection.start();
        return () => {
            connection.stop();
        };
    }, []);

    useEffect(() => {
        setModifiedParameters(environment.parameters);
    }, [trigger]);
    
    const onSaveClick = async (parameters: Parameters) => {
        const result = await dispatch(updateEnvironment(parameters));
        if (result.meta.requestStatus === 'fulfilled')
            setTrigger(trigger === undefined ? true : !trigger);
    }

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