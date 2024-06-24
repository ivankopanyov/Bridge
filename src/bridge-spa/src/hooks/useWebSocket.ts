import { useRef } from "react";
import * as signalR from "@microsoft/signalr";
import { serverHost } from "../environment";

export function useWebSocket(endpoint: string, preload: () => Promise<boolean>, error: (message: string) => void, on?: {
    methodName: string,
    newMethod: (...args: any[]) => any
}[], timeoutMs: number = 3000) {
    const timeout = useRef<NodeJS.Timeout | undefined>();
    const signalRClient = useRef<signalR.HubConnection | undefined>();
    const close = useRef(true);

    const startUpdating = async () => {
        if (close.current)
            return;
        
        const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(`${serverHost}${endpoint}`, {
                skipNegotiation: true,
                transport: signalR.HttpTransportType.WebSockets
            })
            .build();
        
        on && on.forEach(item => hubConnection.on(item.methodName, item.newMethod));

        hubConnection.onclose(async err => {
            if (close.current)
                return;

            signalRClient.current = undefined;
            err && error(err.message);
            await load();
        });
    
        await hubConnection.start()
            .then(() => {
                timeout.current = undefined;
                signalRClient.current = hubConnection;
            })
            .catch(err => {
                error(err.message);
                timeout.current = setTimeout(startUpdating, timeoutMs);
            });
    };

    const load = async () => {
        if (close.current)
            return;

        await preload()
            ? await startUpdating()
            : timeout.current = setTimeout(load, timeoutMs);
    };

    const start = async () => {
        if (close.current) {
            close.current = false;
            await load();
        }
    }

    const stop = async () => {
        if (timeout.current) {
            clearTimeout(timeout.current);
            timeout.current = undefined;
        }

        if (signalRClient.current) {
            await signalRClient.current.stop();
            signalRClient.current = undefined;
        }

        close.current = true;
    };

    return {
        start,
        stop
    }
};

export default useWebSocket;