import { FC, useState } from 'react';
import { Button } from '@mui/material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { signUp } from '../../App/AppStore';
import { Loading, InputText, Text } from '../../components';
import Error from '../../components/Error/Error';
import ParameterHeader from '../../components/ParameterHeader/ParameterHeader';
import './SignUp.scss';

const ok = '✔';
const fail = '✖';

const SignUp: FC = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [confirnPassword, setConfirmPassword] = useState('');
    const dispatch = useAppDispatch();
    const app = useAppSelector(({ app }: RootState) => app);

    const disable = () => {
        const name = username.trim();
        return !/^[A-Za-z][A-Za-z1-9-_]{5,}$/g.test(name) || password.length < 6 || password.length > 50 || password !== confirnPassword;
    };

    const usernameTitle = () => {
        const name = username.trim();
        const length = name.length >= 6 && name.length <= 50 ? ok : fail;
        const regex = /^[A-Za-z1-9-_]*$/g.test(name) ? ok : fail;
        const first = /^[A-Za-z]/g.test(name) ? ok : fail;
        return `Username (${length} Длина в диапазоне от 6 до 50 символов.\n${regex} Содержит только строчные и заглавные буквы латинского алфавита, цифры и знаки дефиса и нижнего подчеркивания.\n${first} Начинается с буквы.)`;
    }

    const passwordTitle = () => 
        `Password (${password.length >= 6 && password.length <= 50 ? ok : fail} Длина в диапазоне от 6 до 50 символов.)`;

    const confirmPasswordTitle = () => 
        `Confirm password (${password === confirnPassword ? ok : fail} Пароли совпадают.)`;
    
    return (
        <>
            { app.error && <Error error={app.error}/> }
            { app.loading && <Loading /> }
            <div>
                <ParameterHeader name={usernameTitle()} />
                <InputText
                    value={username}
                    onChange={setUsername}
                    disabled={app.loading}
                />
            </div>
            <div>
                <ParameterHeader name={passwordTitle()} />
                <InputText
                    value={password}
                    onChange={setPassword}
                    disabled={app.loading}
                    password
                />
            </div>
            <div>
                <ParameterHeader name={confirmPasswordTitle()} />
                <InputText
                    value={confirnPassword}
                    onChange={setConfirmPassword}
                    disabled={app.loading}
                    password
                />
            </div>
            <div className="signup-button-container">
                <Button
                    className="signup-button"
                        onClick={async () => {
                            await dispatch(signUp({
                            username: username.trim(),
                            password: password
                        }));
                    }}
                    disabled={app.loading || disable()}
                >
                    <Text>Sign Up</Text>
                </Button>
            </div>
        </>
    );
}

export default SignUp;
