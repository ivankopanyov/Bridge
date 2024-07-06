import { useEffect, FC } from 'react';
import { Navigate, Route, Routes } from 'react-router-dom';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { auth } from '../../App/AppStore';
import { Loading } from '../../components';
import Error from '../../components/Error/Error';
import SignIn from '../SignIn/SignIn';
import SignUp from '../SignUp/SignUp';
import './Auth.scss';

const Auth: FC = () => {
    const dispatch = useAppDispatch();
    const app = useAppSelector(({ app }: RootState) => app);

    useEffect(() => {
        if (!app.page)
            dispatch(auth());
    }, []);

    useEffect(() => {
        if (!app.loading && !app.page)
            setTimeout(async () => await dispatch(auth()), 3000);
    }, [app.loading]);
    
    return (
        <>
            {
                app.page
                    ? <div className="auth-page-content">
                        <div className="auth-content">
                            <Routes>
                                <Route path={app.page} element={app.page === 'signin' ? <SignIn /> : <SignUp />} />
                                <Route path="*" element={<Navigate to={app.page} replace={true} />} /> 
                            </Routes>
                        </div>
                    </div>
                    : <div>
                        { app.error && <Error error={app.error}/> }
                        <Loading />
                    </div>
            }
        </>
    );
}

export default Auth;
