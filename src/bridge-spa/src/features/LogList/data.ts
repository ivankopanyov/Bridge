export interface LogInfo {
    handlerName?: string;
    status: 'SUCCESS' | 'ERROR' | 'CRITICAL' | 'UNKNOWN';
    error?: string;
    stackTrace?: string;
    dateTime: Date;
    description?: string;
}

export interface TaskInfo {
    logs: LogInfo[];
    queueName?: string;
    handlerName?: string;
    taskId?: string;
    status: 'SUCCESS' | 'ERROR' | 'CRITICAL' | 'UNKNOWN';
    dateTime: Date;
    isEnd: boolean;
    description?: string;
}

export interface LogList {
    tasks: TaskInfo[];
    loading: boolean;
    error?: string;
}