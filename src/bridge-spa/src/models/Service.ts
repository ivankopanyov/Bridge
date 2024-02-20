import OptionsProperty from "./OptionsProperty";
import State from "./State";

export default interface Service {
    name: string;
    hostName: string;
    state: State;
    options?: OptionsProperty[];
    temp?: OptionsProperty[];
}