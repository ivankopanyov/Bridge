export default interface Property {
    name: string;
    value: any;
    type: "string" | "number" | "bigint" | "boolean" | "symbol" | "array" | "map";
    valueType?: "string" | "number" | "bigint" | "boolean" | "symbol";
}