import { useState, FC, PropsWithChildren } from 'react';
import { AppBar, Drawer, Toolbar, CircularProgress } from '@mui/material';
import { Search, Menu, Close, Logout } from '@mui/icons-material';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { NavBarButton, SearchBar, Text } from '../../components';
import { signOut } from '../../App/AppStore';
import useScreenSize from '../../hooks/useScreenSize';
import './NavBar.scss';

interface NavBarProps {
    title?: string;
    icon?: JSX.Element;
    loading?: boolean;
    search?: {
        value: string;
        setValue: (value: string) => void;
    };
    drawer?: JSX.Element;
}

const NavBar: FC<Readonly<PropsWithChildren<NavBarProps>>> = ({ title, icon, loading, search, drawer, children }) => {
    const dispatch = useAppDispatch();
    const app = useAppSelector(({ app }: RootState) => app);
    const [showSearch, setShowSearch] = useState(false);
    const [showDrawer, setShowDrawer] = useState(false);
    const screenSize = useScreenSize();
    const fixSearch = screenSize.width > 700;

    const onSearchClick = () => setShowSearch(true);

    const onMenuClick = () => setShowDrawer(true);

    const onCloseClick = () => {
        search?.setValue('');
        setShowSearch(false);
    };

    const onCloseDrawerClick = () => setShowDrawer(false);
 
    return (
        <div>
            <AppBar className={`nav-bar ${!screenSize.isMobile && 'nav-bar-desktop'}`}>
                <Toolbar>
                    {   
                        (fixSearch || (!fixSearch && !showSearch)) &&
                            <div className="nav-bar-title">
                                {
                                    loading
                                        ? <CircularProgress className="nav-bar-progress" />
                                        : icon
                                }
                                <Text large>{ title }</Text>
                            </div>
                    }
                    {
                        search && fixSearch &&
                            <SearchBar value={search.value} onChange={search.setValue} fixed />
                    }
                    {
                        search && !fixSearch && !showSearch &&
                            <div className="nav-bar-button-right">
                                <NavBarButton onClick={onSearchClick}>
                                    <Search />
                                </NavBarButton>
                            </div>
                    }
                    {
                        drawer && (screenSize.width > 700 || (!fixSearch && !showSearch)) &&
                            <div className="nav-bar-button-right">
                                <NavBarButton onClick={onMenuClick}>
                                    <Menu />
                                </NavBarButton>
                            </div>
                    }
                    {
                        search && !fixSearch && showSearch &&
                            <SearchBar value={search.value} onChange={search.setValue} />
                    }
                    {
                        search && !fixSearch && showSearch &&
                            <div className="nav-bar-button-right">
                                <NavBarButton onClick={onCloseClick}>
                                    <Close />
                                </NavBarButton>
                            </div>
                    }
                    {
                        (!search || (search && (fixSearch || !showSearch))) &&
                            <div className="nav-bar-button-right">
                                {
                                    app.loading
                                        ? <CircularProgress className="nav-bar-progress nav-bar-progess-margin-right" />
                                        : <NavBarButton onClick={async () => await dispatch(signOut())}>
                                            <Logout />
                                        </NavBarButton>
                                }
                            </div>
                    }
                </Toolbar>
            </AppBar>
            <div className="nav-bar-page">
                {
                    <Drawer
                        anchor="right"
                        open={showDrawer}
                        onClose={onCloseDrawerClick}
                    >
                        { drawer }
                    </Drawer>
                }
                <div className="nav-bar-page-content">
                    <div className="nav-bar-content">
                        { children }
                    </div>
                </div>
            </div>
        </div>
    );
};

export default NavBar;