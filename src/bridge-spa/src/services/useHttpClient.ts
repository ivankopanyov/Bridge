export class HttpError extends Error {
    status: number = 0;

    constructor(msg: string, status: number = 0) {
        super(msg === "" ? status.toString() : msg);
        this.status = status;
    }
}

export interface HttpClient {
    get: <T>(urn: string) => Promise<T>;
    getWithoutResponse: (urn: string) => Promise<void>;
    post: <T>(urn: string, body?: object) => Promise<T>;
    postWithoutResponse: (urn: string, body?: object) => Promise<void>;
    update: <T>(urn: string, body?: object) => Promise<T>;
    updateWithoutResponse: (urn: string, body?: object) => Promise<void>;
    remove: (urn: string, body?: object) => Promise<void>;
}

export const useHttpClient = (apiUrl: string): HttpClient => {

    const request = async (urn: string, method: 'GET' | 'POST' | 'PUT' | 'DELETE', body?: object): Promise<Response> => 
        await fetch(apiUrl + '/' + urn, {
                method: method,
                headers: {
                    'accept': 'text/plain',
                    'Content-Type': 'application/json'
                },
                body: body ? JSON.stringify(body) : body
            })
            .then(async response => {
                if (response.ok) {
                    return response;
                } else {
                    let message = "";
                    try {
                        message = await response.text();
                    } catch {
                        message = "Error " + response.status + ": " + response.statusText;
                    }

                    throw new HttpError(message, response.status);
                }
            })
            .catch(err => Promise.reject(!err.status
                ? new HttpError("No connection to the server.", 0)
                : new HttpError(err.message, err.status)));

    const requestWithResponse = async <T>(urn: string, method: 'GET' | 'POST' | 'PUT' | 'DELETE', body?: object): Promise<T> => 
        await request(urn, method, body)
            .then(async response => {
                try {
                    return await response.json();
                } catch {
                    throw new HttpError("Incorrect data was received from the server.", 0);
                }
            });

    const getWithoutResponse = async (urn: string): Promise<void> => await request(urn, 'GET').then();

    const get = async <T>(urn: string): Promise<T> => await requestWithResponse<T>(urn, 'GET')
        .then<Promise<T>>(response => Promise.resolve(response))
        .catch(err => Promise.reject(new HttpError(err.message, err.status)));

    const postWithoutResponse = async (urn: string, body?: object): Promise<void> => await request(urn, 'POST', body).then();

    const post = async <T>(urn: string, body?: object): Promise<T> => await requestWithResponse<T>(urn, 'POST', body);

    const updateWithoutResponse = async (urn: string, body?: object): Promise<void> => await request(urn, 'PUT', body).then();

    const update = async <T>(urn: string, body?: object): Promise<T> => await requestWithResponse<T>(urn, 'PUT', body);
    
    const remove = async (urn: string, body?: object): Promise<void> => await request(urn, 'DELETE', body).then();

    return {
        get,
        getWithoutResponse,
        post,
        postWithoutResponse,
        update,
        updateWithoutResponse,
        remove
    }
}