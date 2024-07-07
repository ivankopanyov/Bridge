import { FC, useState } from 'react';
import { Button } from '@mui/material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { setError, signIn } from '../../App/AppStore';
import { Loading, InputText, Text } from '../../components';
import { NAME_MAX, NAME_MIN, PASS_MAX, PASS_MIN } from '../../environment';
import Error from '../../components/Error/Error';
import ParameterHeader from '../../components/ParameterHeader/ParameterHeader';
import './SignIn.scss';

const SignIn: FC = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const dispatch = useAppDispatch();
    const app = useAppSelector(({ app }: RootState) => app);

    const request = async () => {
        const name = username.trim();
        if (name.length === 0) {
            dispatch(setError('Username required.'));
            return;
        }

        if (password.length === 0) {
            dispatch(setError('Password required.'));
            return;
        }

        if (!new RegExp(`^[A-Za-z][A-Za-z1-9-_]{${NAME_MIN - 1},${NAME_MAX - 1}}$`).test(name) || password.length < PASS_MIN || password.length > PASS_MAX) {
            dispatch(setError('The username or password is incorrect.'));
            return;
        }

        await dispatch(signIn({
            username: name,
            password: password
        }));
    };
    
    return (
        <>
            { app.error && <Error error={app.error}/> }
            { app.loading && <Loading /> }
            <div>
                <ParameterHeader name="Username" />
                <InputText
                    value={username}
                    onChange={setUsername}
                    disabled={app.loading}
                />
            </div>
            <div>
                <ParameterHeader name="Password" />
                <InputText
                    value={password}
                    onChange={setPassword}
                    disabled={app.loading}
                    password
                />
            </div>
            <div className="signin-button-container">
                <Button
                    className="signin-button"
                    onClick={request}
                    disabled={app.loading}
                >
                    <Text>Sign In</Text>
                </Button>
            </div>
        </>
    );
}

export default SignIn;
