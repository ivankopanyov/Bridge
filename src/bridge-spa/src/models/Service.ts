import State from "./State";

export default interface Service {
    name: string;
    hostName: string;
    state: State;
    jsonOptions?: string;
}