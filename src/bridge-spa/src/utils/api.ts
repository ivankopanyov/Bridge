import { serverHost } from "../environment";

export const api = {
    baseURL: `${serverHost}/api/v1.0`,
    get: (endpoint: string) => api.respond('get', endpoint, null),
    post: (endpoint: string, body?: any) => api.respond('post', endpoint, body),
    put: (endpoint: string, body?: any) => api.respond('put', endpoint, body),
    patch: (endpoint: string, body?: any) => api.respond('patch', endpoint, body),
    delete: (endpoint: string) => api.respond('delete', endpoint),
    respond: async (
      method: string,
      endpoint: string,
      body?: any
    ) => {
        const options = body
            ? {
                headers: new Headers({ 'Content-Type': 'application/json' }),
                body: JSON.stringify(body)
            }
            : {};
        
        let response: Response;

        try {
            response = await fetch(api.baseURL + endpoint, { method, ...options });
        } catch(e: any) {
            throw new Error('No connection to the server.');
        }

        if (response.ok) {
            try {
                return await response.json();
            } catch {
                return undefined;
            }
        } else {
            throw new Error(await response.text());
        }
    }
};
