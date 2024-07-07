import { FC, useState } from 'react';
import { Button } from '@mui/material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { signUp } from '../../App/AppStore';
import { Loading, InputText, Text } from '../../components';
import { NAME_MAX, NAME_MIN, PASS_MAX, PASS_MIN } from '../../environment';
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

    const disable = () => !new RegExp(`^[ ]*[A-Za-z][A-Za-z1-9-_]{${NAME_MIN - 1},${NAME_MAX - 1}}[ ]*$`).test(username)
        || password.length < PASS_MIN || password.length > PASS_MAX || password !== confirnPassword;

    const usernameTitle = () => {
        const name = username.trim();
        const length = name.length >= NAME_MIN && name.length <= NAME_MAX ? ok : fail;
        const regex = /^[A-Za-z1-9-_]*$/g.test(name) ? ok : fail;
        const first = /^[A-Za-z]/g.test(name) ? ok : fail;
        return `Username (${length} Длина в диапазоне от ${NAME_MIN} до ${NAME_MAX} символов.\n${regex} Содержит только строчные и заглавные буквы латинского алфавита, цифры и знаки дефиса и нижнего подчеркивания.\n${first} Начинается с буквы.)`;
    }

    const passwordTitle = () => 
        `Password (${password.length >= PASS_MIN && password.length <= PASS_MAX ? ok : fail} Длина в диапазоне от ${PASS_MIN} до ${PASS_MAX} символов.)`;

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
