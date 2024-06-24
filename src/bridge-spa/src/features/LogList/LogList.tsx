import { FC, useEffect, useRef, useState } from "react";
import { MenuBook } from "@mui/icons-material";
import { ViewportList } from "react-viewport-list";
import { useInView } from 'react-intersection-observer';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import { addLog, getTasks, getUpdate, setError } from "./LogListStore";
import { Loading, ScrollView } from "../../components";
import { useLoopRequest, useScreenSize, useWebSocket } from "../../hooks";
import Task from "../Task/Task";
import NavBar from "../../components/NavBar/NavBar";
import Error from '../../components/Error/Error';
import './LogList.scss';

const LogList: FC = () => {
    const dispatch = useAppDispatch();
    const logList = useAppSelector(({ logList }: RootState) => logList);
    const screen = useScreenSize();
    const request = useLoopRequest(async () => {
        const response = await dispatch(getTasks(new Date(logList.tasks[logList.tasks.length - 1].logs[0].dateTime)));
        return response.meta.requestStatus === 'fulfilled';
    });
    const ref = useRef<HTMLDivElement>(null);
    const downRef = useRef<HTMLDivElement>(null);
    const [loadingRef, loadingInView] = useInView();
    const [top, setTop] = useState(false);
    const [search, setSearch] = useState('');
    
    const load = async () => {
        const result = await dispatch(logList.tasks.length === 0
            ? getTasks()
            : getUpdate(new Date(logList.tasks[0].logs[0].dateTime)));
        return result.meta.requestStatus === 'fulfilled';
    };

    const socket = useWebSocket('/logs', load, error => dispatch(setError(error)), [{
        methodName: 'Log',
        newMethod: (message) => dispatch(addLog(JSON.parse(message)))
    }]);

    useEffect(() => {
        if (loadingInView) {
            downRef.current?.scrollIntoView();
            if (logList.tasks.length > 0 && !logList.isEnd) {
                request.start();
            }
        } else {
            request.stop();
        }
    }, [loadingInView]);

    useEffect(() => {
        return () => {
            socket.stop();
            request.stop();
        }
    }, []);
    
    return (
        <NavBar
            title="Logs"
            icon={<MenuBook className="log-list-icon" />}
            loading={(logList.loading && top) || (logList.bottomLoading && logList.tasks.length === 0)}
            search={{
                value: search,
                setValue: setSearch
            }}
        >
            <ScrollView
                onTopChanged={value => {
                    setTop(value);
                    value ? socket.start() : socket.stop();
                }}
                onBottomChanged={async value => {
                    if (!logList.isEnd && value && !logList.bottomLoading && logList.tasks.length > 0)
                        await dispatch(getTasks(new Date(logList.tasks[logList.tasks.length - 1].logs[0].dateTime)));
                }}
                fab
            >
                { logList.error && <Error error={logList.error} /> }
                {
                    logList.tasks.length > 0 && 
                        <div ref={ref}>
                            <ViewportList viewportRef={ref} items={logList.tasks}>
                                { task => <Task key={task.logs[0].taskId} task={task} /> }
                            </ViewportList>
                        </div>
                }
                {
                    (logList.bottomLoading && logList.tasks.length > 0) &&
                        <div ref={loadingRef}>
                            <Loading />
                        </div>
                }
                <div className={screen.isMobile ? 'log-list-bottom-mobile' : ''} />
                <div ref={downRef} />
            </ScrollView>
        </NavBar>
    );
};

export default LogList;
