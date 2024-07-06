import { useRef } from "react";

export function useLoopRequest(preload: () => Promise<boolean>, timeoutMs: number = 3000) {
    const timeout = useRef<NodeJS.Timeout | undefined>();
    const close = useRef(true);

    const load = async () => {
        if (close.current)
            return;

        if (!await preload())
            timeout.current = setTimeout(load, timeoutMs);
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

        close.current = true;
    };

    return {
        start,
        stop
    }
};

export default useLoopRequest;