import { FC } from "react";
import { CircularProgress } from "@mui/material";
import './Loading.scss';

export const Loading: FC = () => {
    return (
        <div className="loading-progress-container">
            <CircularProgress className="loading-progress" />
        </div>
    );
};

export default Loading;