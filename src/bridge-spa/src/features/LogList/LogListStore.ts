import { PayloadAction, createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { LogList, LogInfo, LogData } from './data';
import { api } from '../../utils/api';

export const pageSize = 100;
const maxSize = pageSize * 3;

const defaultHostList: LogList = {
    tasks: [],
    loading: false,
    bottomLoading: false,
    isEnd: false,
    auth: true
};

export const getTasks = createAsyncThunk('logList/getTasks', async (to?: Date) => await api.post('/logs', {
    size: pageSize,
    to: to?.toJSON()
}));

export const getTask = createAsyncThunk('logList/getTask', async (id: string) => await api.get(`/logs/${id}`));

export const getLog = createAsyncThunk('logList/getLog', async (id: {
    taskId: string;
    id: string;
}) => await api.get(`/logs/${id.taskId}/${id.id}`));

const addLogs = (state: LogList, logs: LogInfo[], splice = false) => {
    let sort = false;
    logs.forEach(log => {
        const task = state.tasks.find(t => t.logs[0].taskId === log.taskId);
        if (task) {
            if (log.dateTime > task.logs[0].dateTime && !task.loading) {
                task.logs = [log];
                sort = true;
            }
        } else {
            state.tasks.push({
                logs: [log]
            });
            sort = true;
        }
    });

    if (sort) {
        state.tasks.sort((a, b) => {
            if (a.logs[0].dateTime === b.logs[0].dateTime)
                return 0;

            return a.logs[0].dateTime > b.logs[0].dateTime ? 1 : -1;
        });
    }
    
    if (splice) {
        state.tasks.length > maxSize && state.tasks.splice(maxSize, state.tasks.length - maxSize);
        state.loading = false;
    } else {
        state.bottomLoading = false;
    }
    
    state.error = undefined;
};

const initialState: LogList = defaultHostList;

const logListSlice = createSlice({
    name: 'logList',
    initialState,
    reducers: {
        addLog(state, action: PayloadAction<LogInfo>) {
            const log = action.payload;
            const task = state.tasks.find(t => t.logs[0].taskId === log.taskId);
            let sort = false;
            if (task) {
                if (task.loading !== false) {
                    if (log.dateTime > task.logs[0].dateTime) {
                        task.logs[0] = log;
                        sort = true;
                    }
                } else {
                    if (!task.logs.find(l => l.id === log.id)) {
                        sort = log.dateTime > task.logs[0].dateTime;
                        task.logs.push(log);
                        task.logs.sort((a, b) => {
                            if (a.dateTime === b.dateTime)
                                return 0;

                            return a.dateTime > b.dateTime ? -1 : 1;
                        });
                    }
                }
            } else {
                state.tasks.push({
                    logs: [log]
                });
                sort = true;
            }

            if (sort) {
                state.tasks.sort((a, b) => {
                    if (a.logs[0].dateTime === b.logs[0].dateTime)
                        return 0;

                    return a.logs[0].dateTime > b.logs[0].dateTime ? -1 : 1;
                });
            }

            if (state.tasks.length > maxSize) {
                state.tasks.splice(maxSize, state.tasks.length - maxSize);
            }
        },
        addLogRange(state, action: PayloadAction<{
            logs: LogInfo[],
            splice: boolean
        }>) {
            const { logs, splice } = action.payload;
            addLogs(state, logs, splice);
        },
        setLoading(state, action: PayloadAction<boolean>) {
            state.loading = action.payload
        },
        setError(state, action: PayloadAction<string | undefined>) {
            state.error = action.payload;
        },
        authorized(state) {
            state.auth = true;
        }
    },
    extraReducers: (builder) => {
        builder.addCase(getTasks.pending, (state) => {
            state.bottomLoading = true;
        });
        builder.addCase(getTasks.fulfilled, (state, action: PayloadAction<LogInfo[]>) => {
            addLogs(state, action.payload);
        });
        builder.addCase(getTasks.rejected, (state, action) => {
            if (action.error.code === '401')
                state.auth = false;
            else
                state.error = action.error.message;
        });
        
        builder.addCase(getTask.pending, (state, action) => {
            const id = action.meta.arg;
            const task = state.tasks.find(t => t.logs[0].taskId === id);
            if (task)
                task.loading = true;
        });
        builder.addCase(getTask.fulfilled, (state, action: PayloadAction<LogInfo[]>) => {
            const logs = action.payload;
            const task = state.tasks.find(t => t.logs[0].taskId === logs[0].taskId);
            if (task) {
                let logSort = false;
                let sort = false;
                logs.forEach(log => {
                    const first = task.logs[0].dateTime;
                    if (!task.logs.find(l => l.id === log.id)) {
                        task.logs.push(log);
                        logSort = true;
                        if (log.dateTime > first) {
                            sort = true;
                        }
                    }
                });

                if (logSort) {
                    task.logs.sort((a, b) => {
                        if (a.dateTime === b.dateTime)
                            return 0;

                        return a.dateTime > b.dateTime ? -1 : 1;
                    });
                }

                if (sort) {
                    state.tasks.sort((a, b) => {
                        if (a.logs[0].dateTime === b.logs[0].dateTime)
                            return 0;

                        return a.logs[0].dateTime > b.logs[0].dateTime ? -1 : 1;
                    }); 
                }

                task.loading = false;
                task.error = undefined;
            }
        });
        builder.addCase(getTask.rejected, (state, action) => {
            const id = action.meta.arg;
            const task = state.tasks.find(t => t.logs[0].taskId === id);
            if (task) {
                task.loading = undefined;
                if (action.error.code !== '401')
                    task.error = action.error.message;
            }

            if (action.error.code === '401')
                state.auth = false;
        });

        
        builder.addCase(getLog.pending, (state, action) => {
            const { taskId, id } = action.meta.arg;
            const log = state.tasks.find(t => t.logs[0].taskId === taskId)?.logs?.find(l => l.id === id);
            if (log)
                log.loading = true;
        });
        builder.addCase(getLog.fulfilled, (state, action: PayloadAction<LogData>) => {
            const logData = action.payload;
            if (logData.inputObjectJson)
                logData.inputObjectJson = JSON.stringify(JSON.parse(logData.inputObjectJson), null, 4);
            
            const log = state.tasks.find(t => t.logs[0].taskId === logData.taskId)?.logs?.find(l => l.id === logData.logId);
            if (log) {
                log.data = logData;
                log.loading = false;
                log.error = undefined;
            }
        });
        builder.addCase(getLog.rejected, (state, action) => {
            const { taskId, id } = action.meta.arg;
            const log = state.tasks.find(t => t.logs[0].taskId === taskId)?.logs?.find(l => l.id === id);
            if (log) {
                log.loading = undefined;
                if (action.error.code !== '401')
                    log.error = action.error.message;
            }

            if (action.error.code === '401')
                state.auth = false;
        });
    }
});

export const {
    addLog,
    addLogRange,
    setLoading,
    setError,
    authorized
} = logListSlice.actions;

export default logListSlice.reducer;
