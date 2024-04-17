import { FC, PropsWithChildren } from "react";
import { IconButton } from "@mui/material";
import './NavBarButton.scss';

interface NavBarButtonProps {
    onClick: () => void;
}

export const NavBarButton: FC<Readonly<PropsWithChildren<NavBarButtonProps>>> = ({ onClick, children }) => {
    return (
        <IconButton 
            className="nav-bar-button"
            size="large"
            edge="end"
            onClick={onClick}
        >
            { children }
        </IconButton>
    );
};

export default NavBarButton;