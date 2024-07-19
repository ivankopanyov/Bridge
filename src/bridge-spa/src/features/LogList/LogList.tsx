import { FC, useEffect, useRef, useState } from "react";
import { MenuBook } from "@mui/icons-material";
import { ViewportList } from "react-viewport-list";
import { useInView } from "react-intersection-observer";
import { useAppDispatch, useAppSelector } from "../../redux/hooks";
import { RootState } from "../../redux/store";
import {
  pageSize,
  addLog,
  addLogRange,
  getTasks,
  setError,
  setLoading,
  authorized,
} from "./LogListStore";
import { Loading, ScrollView } from "../../components";
import { useConnection, useLoopRequest, useScreenSize } from "../../hooks";
import { api } from "../../utils/api";
import { unauthorized } from "../../App/AppStore";
import Task from "../Task/Task";
import NavBar from "../NavBar/NavBar";
import Error from "../../components/Error/Error";
import "./LogList.scss";

const LogList: FC = () => {
  const dispatch = useAppDispatch();
  const app = useAppSelector(({ app }: RootState) => app);
  const logList = useAppSelector(({ logList }: RootState) => logList);
  const screen = useScreenSize();
  const connection = useConnection("/logs", {
    invoke: () => {
      dispatch(setLoading(true));
      return logList.tasks.length === 0
        ? ["Tasks", [pageSize]]
        : ["Update", [new Date(logList.tasks[0].logs[0].dateTime)]];
    },
    callback: (running, authError, message) => {
      if (authError) {
        dispatch(unauthorized());
      } else {
        dispatch(setLoading(!running));
        dispatch(setError(message));
      }
    },
    auth: api.refresh,
    handlers: [
      ["Log", (log) => dispatch(addLog(log))],
      [
        "Logs",
        (logs, update) =>
          dispatch(
            addLogRange({
              logs: logs,
              splice: update,
            })
          ),
      ],
    ],
  });
  const request = useLoopRequest(async () => {
    const response = await dispatch(
      getTasks(
        new Date(logList.tasks[logList.tasks.length - 1].logs[0].dateTime)
      )
    );
    return response.meta.requestStatus === "fulfilled";
  });
  const ref = useRef<HTMLDivElement>(null);
  const downRef = useRef<HTMLDivElement>(null);
  const [loadingRef, loadingInView] = useInView();
  const [top, setTop] = useState(false);
  const [search, setSearch] = useState("");

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
      connection.stop();
      request.stop();
    };
  }, []);

  useEffect(() => {
    if (!logList.auth) {
      dispatch(authorized());
      dispatch(unauthorized());
    }
  }, [logList.auth]);

  return (
    <NavBar
      title="Logs"
      icon={<MenuBook className="log-list-icon" />}
      loading={
        (logList.loading && top) ||
        (logList.bottomLoading && logList.tasks.length === 0)
      }
      search={{
        value: search,
        setValue: setSearch,
      }}
    >
      <ScrollView
        onTopChanged={async (value) => {
          setTop(value);
          value ? await connection.start() : await connection.stop();
        }}
        onBottomChanged={async (value) => {
          if (
            !logList.isEnd &&
            value &&
            !logList.bottomLoading &&
            logList.tasks.length > 0
          )
            await dispatch(
              getTasks(
                new Date(
                  logList.tasks[logList.tasks.length - 1].logs[0].dateTime
                )
              )
            );
        }}
        fab
      >
        {logList.error && <Error error={logList.error} />}
        {logList.tasks.length > 0 && (
          <div ref={ref}>
            <ViewportList viewportRef={ref} items={logList.tasks}>
              {(task) => <Task key={task.logs[0].taskId} task={task} />}
            </ViewportList>
          </div>
        )}
        {logList.bottomLoading && logList.tasks.length > 0 && (
          <div ref={loadingRef}>
            <Loading />
          </div>
        )}
        <div className={screen.isMobile ? "log-list-bottom-mobile" : ""} />
        <div ref={downRef} />
      </ScrollView>
    </NavBar>
  );
};

export default LogList;
