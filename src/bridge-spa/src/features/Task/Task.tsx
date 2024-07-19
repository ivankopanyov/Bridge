import { useState, FC, useEffect, useRef } from "react";
import { Accordion } from "@mui/material";
import {
  CreditScore,
  CreditCard,
  CreditCardOff,
  HowToReg,
  Person,
  PersonOff,
  PublishedWithChanges,
  Sync,
  SyncDisabled,
  UnfoldLess,
} from "@mui/icons-material";
import { TaskInfo } from "../LogList/data";
import { getTask } from "../LogList/LogListStore";
import {
  AccordionBody,
  AccordionHeader,
  Text,
  Loading,
} from "../../components";
import { useAppDispatch } from "../../redux/hooks";
import { useLoopRequest } from "../../hooks";
import Log from "../LogInfo/Log";
import "./Task.scss";

interface TaskProps {
  task: TaskInfo;
}

const Task: FC<Readonly<TaskProps>> = ({ task }) => {
  const dispatch = useAppDispatch();
  const [expanded, setExpanded] = useState<boolean>(false);
  const loopRequest = useLoopRequest(async () => {
    const result = await dispatch(getTask(task.logs[0].taskId));
    return result.meta.requestStatus === "fulfilled";
  });

  useEffect(() => {
    if (expanded && task.loading !== false) {
      loopRequest.start();
    } else if (!expanded) {
      loopRequest.stop();
    }
  }, [expanded]);

  useEffect(() => {
    return () => {
      loopRequest.stop();
    };
  }, []);

  return (
    <Accordion expanded={expanded} onChange={(_e, s) => setExpanded(s)}>
      <AccordionHeader>
        <div className="task-header">
          <div className="task-indent-right">
            {{
              RESV: task.logs[0].isEnd ? (
                task.logs[0].isError ? (
                  <PersonOff className="task-icon-fail" />
                ) : (
                  <HowToReg className="task-icon-success" />
                )
              ) : (
                <Person
                  className={
                    task.logs[0].isError ? "task-icon-fail" : "task-icon"
                  }
                />
              ),
              POST: task.logs[0].isEnd ? (
                task.logs[0].isError ? (
                  <CreditCardOff className="task-icon-fail" />
                ) : (
                  <CreditScore className="task-icon-success" />
                )
              ) : (
                <CreditCard
                  className={
                    task.logs[0].isError ? "task-icon-fail" : "task-icon"
                  }
                />
              ),
            }[task.logs[0].taskName ?? ""] ||
              (task.logs[0].isEnd ? (
                task.logs[0].isError ? (
                  <SyncDisabled className="task-icon-fail" />
                ) : (
                  <PublishedWithChanges className="task-icon-success" />
                )
              ) : (
                <Sync
                  className={
                    task.logs[0].isError ? "task-icon-fail" : "task-icon"
                  }
                />
              ))}
          </div>
          <div>
            <div className="task-header-name">
              <Text>{task.logs[0].dateTime.display()}</Text>
              {!expanded && task.logs[0].handlerName && (
                <div className="task-handler task-indent-left">
                  <Text>{task.logs[0].handlerName}</Text>
                </div>
              )}
            </div>
            {!expanded && task.logs[0].message && (
              <Text assignment="description" multiline>
                {task.logs[0].message}
              </Text>
            )}
            {expanded && task.error && (
              <Text assignment="error" multiline>
                {task.error}
              </Text>
            )}
          </div>
        </div>
      </AccordionHeader>
      <AccordionBody indent>
        {task.logs.map((log, index) => (
          <Log key={index} log={log} />
        ))}
        {(task.loading === undefined || task.loading) && <Loading />}
      </AccordionBody>
    </Accordion>
  );
};

export default Task;
