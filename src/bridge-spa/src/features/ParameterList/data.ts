interface Parameter<T> {
    name: string;
    value: T;
}

interface KeyValue<T> {
    key: string,
    value: T
}

export interface Parameters {
    booleanParameters: Parameter<boolean>[];
    stringParameters: Parameter<string>[];
    listParameters: Parameter<string[]>[];
    booleanMapParameters: Parameter<KeyValue<boolean>[]>[];
    stringMapParameters: Parameter<KeyValue<string>[]>[];
}
