import { useRef } from "react";
import * as signalR from "@microsoft/signalr";
import { serverHost } from "../environment";

interface ConnectionProps {
    ms?: number;
    handlers?: [string, (...args: any[]) => void][];
    invoke?: () => [string, any[]];
    auth?: () => Promise<void>;
    callback?: (running: boolean, authError?: boolean, message?: string) => void;
}

export function useConnection(endpoint: string, props?: ConnectionProps) {
    const { invoke, handlers, auth, callback} = props ?? {};
    const ms = props?.ms ?? 3000;
    const hubConnection = useRef<signalR.HubConnection>();
    const timeout = useRef<NodeJS.Timeout>();
  
    const start = async () => {
        if (timeout.current || (hubConnection.current
            && hubConnection.current.state !== signalR.HubConnectionState.Disconnecting
            && hubConnection.current.state !== signalR.HubConnectionState.Disconnected))
            return;
    
        await startConnection();
    };
  
    const stop = async () => {
        if (timeout.current)
            clearTimeout(timeout.current);

        if (hubConnection.current 
            && hubConnection.current.state !== signalR.HubConnectionState.Disconnecting
            && hubConnection.current.state !== signalR.HubConnectionState.Disconnected) {
            await hubConnection.current.stop();
            hubConnection.current = undefined;
        }
    };
  
    const startConnection = async (): Promise<void> => {
        const connection = new signalR.HubConnectionBuilder()
            .withUrl(`${serverHost}${endpoint}`, {
                transport: signalR.HttpTransportType.LongPolling
            })
            .withAutomaticReconnect({
              nextRetryDelayInMilliseconds: () => ms
            })
            .build();
        
        handlers && handlers.forEach(handler => connection.on(handler[0], handler[1]));
        connection.onreconnecting(error => failedCallback(error?.message));
        connection.onreconnected(async () => invoke && await invokeMethod(connection, invoke));
        hubConnection.current = connection;

        await connection
            .start()
            .then(async () => invoke 
                ? await invokeMethod(connection, invoke)
                : success())
            .catch(async error => {
                if (error.message?.includes('401')) {
                    auth ? await refresh(auth) : failedAuth();
                } else {
                    failed(async () => await startConnection(), error?.message);
                }
            });
    };
  
    const invokeMethod = async (connection: signalR.HubConnection, method: () => [string, ...any[]]) => {
        const data = method();
        await connection
            .invoke(data[0], ...data[1])
            .then(() => success())
            .catch(error => {
                failed(async () => await invokeMethod(connection, method), error?.message);
            });
    };
  
    const refresh = async (authMethod: () => Promise<void>) => await authMethod()
        .then(() => timeout.current = setTimeout(async () => await startConnection(), ms))
        .catch(error => {
            if (error.code === '401') {
                failedAuth();
            } else {
                failed(async () => await refresh(authMethod), error?.message);
            }
        });

    const success = () => callback && callback(true);

    const failed = (method: () => void, message?: string) => {
        failedCallback(message);
        timeout.current = setTimeout(method, ms);
    }

    const failedCallback = (message?: string) => callback && callback(false, false, message);

    const failedAuth = () => {
        timeout.current = undefined;
        hubConnection.current = undefined;
        callback && callback(false, true);
    };
    
    return {
        start,
        stop
    }
};

export default useConnection;
