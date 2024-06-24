import { Parameters } from "../features/ParameterList/data";

export const parametersToObject = (parameters: Parameters) => Object.fromEntries([
    ...parameters.booleanParameters.map(p => [p.name, p.value]),
    ...parameters.stringParameters.map(p => [p.name, p.value]),
    ...parameters.listParameters.map(p => [p.name, p.value]),
    ...parameters.booleanMapParameters.map(p => [p.name, Object.fromEntries(p.value.map(i => [i.key, i.value]))]),
    ...parameters.stringMapParameters.map(p => [p.name, Object.fromEntries(p.value.map(i => [i.key, i.value]))])
]);

export const objectToParameters = (obj: any): Parameters => {
    const parameters: Parameters = {
        booleanParameters: [],
        stringParameters: [],
        listParameters: [],
        booleanMapParameters: [],
        stringMapParameters: []
    };

    const values = Object.values<any>(obj);
    Object.keys(obj).forEach((key, index) => { 
        switch (getType(values[index])) {
            case 'boolean':
                const booleanValue = Boolean(values[index]);
                parameters.booleanParameters.push({
                    name: key,
                    value: booleanValue
                });
                break;

            case 'string':
                const stringValue = String(values[index]);
                parameters.stringParameters.push({
                    name: key,
                    value: stringValue
                });
                break;
                
            case 'array':
                const listValue = [...values[index]].map(i => String(i));
                parameters.listParameters.push({
                    name: key,
                    value: listValue
                });
                break;
                
            case 'map':
                const mapValues = Object.values<any>(values[index]);
                if (mapValues.length > 0 && getType(mapValues[0]) === 'boolean') {
                    parameters.booleanMapParameters.push({
                        name: key,
                        value: Object.keys(values[index]).map((k, i) => { return {
                            key: k,
                            value: Boolean(mapValues[i])
                        }})
                    });
                } else {
                    parameters.stringMapParameters.push({
                        name: key,
                        value: Object.keys(values[index]).map((k, i) => { return {
                            key: k,
                            value: String(mapValues[i])
                        }})
                    });
                }
                break;
        }
    });

    return parameters;
}

export const toDisplayDateTime = (date: Date) => {
    date = new Date(date);
    return `${toDisplayNumber(date.getDate())}.${toDisplayNumber(date.getMonth() + 1)}.${date.getFullYear()} ${toDisplayNumber(date.getHours())}:${toDisplayNumber(date.getMinutes())}:${toDisplayNumber(date.getSeconds())}`;
}

const toDisplayNumber = (value: number) => value.toString().padStart(2, '0');

const getType = (value: any): 'boolean' | 'string' | 'array' | 'map' => {
    const type = typeof value;
    if (type === 'boolean')
        return 'boolean';
    if (type === 'object')
        return Array.isArray(value) ? 'array' : 'map';
    return 'string';
};