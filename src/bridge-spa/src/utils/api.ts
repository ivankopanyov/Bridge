import { SERVER_HOST } from "../environment";

class HttpError extends Error {
    readonly code: string = '0';
  
    constructor(message: string, code: number = 0) {
        super(message === '' ? `Error code: ${code.toString()}` : message);
        this.code = code.toString();
    }
}

export const api = {
    baseURL: `${SERVER_HOST}/api/v1.0`,
    get: (endpoint: string) => api.respond('get', endpoint),
    post: (endpoint: string, body?: any) => api.respond('post', endpoint, body),
    put: (endpoint: string, body?: any) => api.respond('put', endpoint, body),
    patch: (endpoint: string, body?: any) => api.respond('patch', endpoint, body),
    delete: (endpoint: string) => api.respond('delete', endpoint),
    refresh: () => api.respond('get', '/auth/refresh', undefined, false),
    respond: async (method: string, endpoint: string, options?: any, refresh: boolean = true): Promise<any | undefined> => {
        let response: Response;
        try {
            response = await fetch(`${api.baseURL}${endpoint}`, {
                method: method,
                credentials : 'include',
                headers: options ? new Headers({'Content-Type': 'application/json'}) : undefined,
                body: options ? JSON.stringify(options) : undefined
            });
        } catch {
            throw new HttpError('No connection to the server.', 0);
        }
  
        if (response.ok) {
            try {
                return await response.json();
            } catch {
                return undefined;
            }
        }
        
        if (response.status === 401) {
          if (refresh) {
            await api.refresh();
            return api.respond(method, endpoint, options, false);
          } else {
            throw new HttpError('Authentication failed.', 401);
          }
        }
        
        throw new HttpError(await response.text(), response.status);
    }
};
