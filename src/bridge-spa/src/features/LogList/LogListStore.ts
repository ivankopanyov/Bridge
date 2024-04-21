import { PayloadAction, createSlice } from '@reduxjs/toolkit';
import { LogList } from './data';

export interface Log {
    queueName?: string;
    handlerName?: string;
    taskId?: string;
    logLevel: number;
    error?: string;
    stackTrace?: string;
    dateTime: Date;
    isEnd: boolean;
    description?: string;
}

const defaultHostList: LogList = {
    tasks: [],
    loading: false
};

const getStatus = (logLevel: number): 'SUCCESS' | 'ERROR' | 'CRITICAL' | 'UNKNOWN' => {
    switch (logLevel) {
        case 2:
            return 'SUCCESS';

        case 4:
            return 'ERROR';

        case 5:
            return 'CRITICAL';

        default:
            return 'UNKNOWN';
    }
}

const initialState: LogList = defaultHostList;

const logListSlice = createSlice({
    name: 'logList',
    initialState,
    reducers: {
        updateTask(state, action: PayloadAction<Log>) {
            const { queueName, handlerName, taskId, logLevel, error, stackTrace, dateTime, isEnd, description } = action.payload;
            const status = getStatus(logLevel);

            const date = new Date(dateTime);
            const log = description ?? error ?? stackTrace;

            if (taskId) {
                let task = state.tasks.find(t => t.taskId === taskId);
                if (!task) {
                    task = {
                        queueName: queueName,
                        handlerName: handlerName,
                        taskId: taskId,
                        status: status,
                        dateTime: date,
                        isEnd: isEnd,
                        description: log,
                        logs: []
                    };

                    state.tasks.push(task);
                } else {
                    task.queueName = queueName;
                    task.handlerName = handlerName;
                    task.taskId = taskId;
                    task.status = status;
                    task.dateTime = date;
                    task.isEnd = isEnd;
                    task.description = log;
                }

                task.logs.push({
                    handlerName: handlerName,
                    status: status,
                    error: error,
                    stackTrace: stackTrace,
                    dateTime: date,
                    description: log
                });

                task.logs = task.logs.sort((a, b) => {
                    if (a.dateTime === b.dateTime)
                        return 0;

                    return a.dateTime < b.dateTime ? 1 : -1;
                });

                state.tasks = state.tasks.sort((a, b) => {
                    if (a.dateTime === b.dateTime)
                        return 0;

                    return a.dateTime < b.dateTime ? 1 : -1;
                });
            }
        }
    }
});

export const {
    updateTask
} = logListSlice.actions;

export default logListSlice.reducer;
