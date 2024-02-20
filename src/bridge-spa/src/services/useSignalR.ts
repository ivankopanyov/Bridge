import { useRef } from "react";
import * as signalR from "@microsoft/signalr";
import { ServiceViewModel } from "../viewModels/useServiceViewModel";

export interface SignalR {
    connect: () => Promise<void>;
    disconnect: () => Promise<void>;
};

export const useSignalR = (apiUrl: string,
    serviceViewModel: ServiceViewModel,
    connectHandle: () => Promise<void>,
    errorHandle: (message?: string) => void) => {

    const currentHubConnection = useRef<signalR.HubConnection | null>(null);
    const state = useRef<boolean>(true);

    const connect = async (): Promise<void> => {
        state.current = true;
        await connecting();
    };
    
    const disconnect = async (): Promise<void> => {
        state.current = false;
        errorHandle(undefined);
        await disconnecting();
    };

    const connecting = async (): Promise<void> => {
        if (!state.current)
            return;

        errorHandle("Connecting to the server.");

        currentHubConnection.current = null;

        const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(apiUrl + "/update", {
                skipNegotiation: true,
                transport: signalR.HttpTransportType.WebSockets
            })
            .configureLogging(signalR.LogLevel.Information)  
            .build();

        hubConnection.on("Update", (message) => {
            console.log(message);
            try {
                serviceViewModel.updateService(JSON.parse(message));
            } catch (e) {
                console.log(e);
            }
        });

        hubConnection.on("RemoveService", (message) => {
            try {
                serviceViewModel.removeService(JSON.parse(message));
            } catch (e) {
                console.log(e);
            }
        });

        hubConnection.on("RemoveHost", (message) => {
            try {
                serviceViewModel.removeHost(JSON.parse(message));
            } catch (e) {
                console.log(e);
            }
        });

        hubConnection.onclose(() => connecting());
    
        await hubConnection.start()
            .then(async () => {
                currentHubConnection.current = hubConnection;
                errorHandle(undefined);
                await connectHandle();
            })
            .catch(() => {
                errorHandle("No connection to the server.");
                setTimeout(() => connecting(), 1000);
            });
    };

    const disconnecting = async (): Promise<void> => {
        if (currentHubConnection.current !== null && currentHubConnection.current.state === signalR.HubConnectionState.Connected) {
            currentHubConnection.current.stop().catch(() => setTimeout(() => disconnecting(), 1000));
        } else
            currentHubConnection.current = null;
    };

    return {
        connect,
        disconnect
    };
};