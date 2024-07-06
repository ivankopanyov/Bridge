export interface LogData {
    logId: string;
    taskId: string;
    error?: string;
    stackTrace?: string;
    inputObjectJson?: string;
}

export interface LogInfo {
    id: string;
    taskId: string;
    taskName?: string;
    handlerName?: string;
    dateTime: Date;
    isError: boolean;
    isEnd: boolean;
    message?: string;
    data?: LogData;
    loading?: boolean;
    error?: string;
}

export interface TaskInfo {
    logs: LogInfo[];
    loading?: boolean;
    error?: string;
}

export interface LogList {
    tasks: TaskInfo[];
    loading: boolean;
    bottomLoading: boolean;
    error?: string;
    isEnd: boolean;
    auth: boolean;
}
