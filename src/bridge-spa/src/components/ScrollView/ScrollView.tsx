import { FC, PropsWithChildren, useRef, useState, useEffect } from "react";
import { Fab } from "@mui/material";
import { KeyboardArrowUp } from "@mui/icons-material";
import { useInView } from "react-intersection-observer";
import useScreenSize from "../../hooks/useScreenSize";
import './ScrollView.scss';

interface ScrollViewProps {
    fab?: boolean;
    onTopChanged?: (value: boolean) => void;
    onBottomChanged?: (value: boolean) => void;
}

export const ScrollView: FC<Readonly<PropsWithChildren<ScrollViewProps>>> = ({ children, fab, onTopChanged, onBottomChanged }) => {
    const screenSize = useScreenSize();
    const [topRef, topInView] = useInView();
    const [bottomRef, bottomInView] = useInView();
    const upRef = useRef<HTMLDivElement>(null);
    const downRef = useRef<HTMLDivElement>(null);
    const [top, setTop] = useState(true);

    useEffect(() => { 
        setTop(topInView);
        onTopChanged && onTopChanged(topInView);
    }, [topInView]);

    useEffect(() => {
        onBottomChanged && onBottomChanged(bottomInView);
    }, [bottomInView]);

    return (
        <div>
            <div ref={topRef} />
            <div ref={upRef} />
            <div className="list-top" />
            { children }
            <div ref={bottomRef} />
            <div ref={downRef} />
            {
                fab && !top && 
                    <Fab
                        className={`list-fab ${screenSize.isMobile && 'list-fab-mobile'}`}
                        onClick={() => upRef.current?.scrollIntoView()}
                    >
                        <KeyboardArrowUp />
                    </Fab>
            }
        </div>
    );
};

export default ScrollView;