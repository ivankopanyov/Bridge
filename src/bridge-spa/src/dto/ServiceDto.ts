import State from "../models/State";

export default interface ServiceDto {
    name: string;
    hostName: string;
    state: State;
    jsonOptions?: string;
}