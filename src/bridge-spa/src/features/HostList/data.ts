export interface Parameter<T> {
    name: string;
    value: T;
}

export interface KeyValue<T> {
    key: string,
    value: T
}

export interface ServiceInfo {
    hostName: string;
    name: string;
    isActive: boolean;
    error?: string;
    stackTrace?: string;
    loading: boolean;
    updateError?: string;
    booleanParameters: Parameter<boolean>[];
    stringParameters: Parameter<string>[];
    listParameters: Parameter<string[]>[];
    booleanMapParameters: Parameter<KeyValue<boolean>[]>[];
    stringMapParameters: Parameter<KeyValue<string>[]>[];
}

export interface HostInfo {
    name: string,
    services: ServiceInfo[],
    activeServiceCount: number;
    error: boolean
}

export interface HostList {
    hosts: HostInfo[];
    serviceCount: number;
    activeServiceCount: number;
    loading: boolean;
    error?: string;
}