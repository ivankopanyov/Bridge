import { useState, FC, PropsWithChildren } from 'react';
import { AppBar, Box, Drawer, Toolbar } from '@mui/material';
import { Search, Menu, Close } from '@mui/icons-material';
import useScreenSize from '../../hooks/useScreenSize';
import { NavBarButton, SearchBar, Text } from '..';
import './NavBar.scss';

interface NavBarProps {
    title?: string;
    icon?: JSX.Element;
    search?: {
        value: string;
        setValue: (value: string) => void;
    };
    drawer?: JSX.Element;
}

const NavBar: FC<Readonly<PropsWithChildren<NavBarProps>>> = ({ title, icon, search, drawer, children }) => {
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
        <Box>
            <AppBar className={`nav-bar ${!screenSize.isMobile && 'nav-bar-desktop'}`}>
                <Toolbar>
                    {   
                        (fixSearch || (!fixSearch && !showSearch)) &&
                            <Box className="nav-bar-title">
                                { icon && icon }
                                <Text large>{ title }</Text>
                            </Box>
                    }
                    {
                        search && fixSearch &&
                            <SearchBar value={search.value} onChange={search.setValue} fixed />
                    }
                    {
                        search && !fixSearch && !showSearch &&
                            <Box className="nav-bar-button-right">
                                <NavBarButton onClick={onSearchClick}>
                                    <Search />
                                </NavBarButton>
                            </Box>
                    }
                    {
                        drawer && (screenSize.width > 700 || (!fixSearch && !showSearch)) &&
                            <Box className="nav-bar-button-right">
                                <NavBarButton onClick={onMenuClick}>
                                    <Menu />
                                </NavBarButton>
                            </Box>
                    }
                    {
                        search && !fixSearch && showSearch &&
                            <SearchBar value={search.value} onChange={search.setValue} />
                    }
                    {
                        search && !fixSearch && showSearch &&
                            <Box className="nav-bar-button-right">
                                <NavBarButton onClick={onCloseClick}>
                                    <Close />
                                </NavBarButton>
                            </Box>
                    }
                </Toolbar>
            </AppBar>
            <Box className="nav-bar-page">
                {
                    <Drawer
                        anchor="right"
                        open={showDrawer}
                        onClose={onCloseDrawerClick}
                    >
                        { drawer }
                    </Drawer>
                }
                { children }
            </Box>
        </Box>
    );
};

export default NavBar;