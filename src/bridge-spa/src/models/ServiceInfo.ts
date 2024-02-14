import ServiceOptions from "./ServiceOptions";
import ServiceState from "./ServiceState";

export default interface ServiceInfo {
    name: string;
    state: ServiceState;
    options: ServiceOptions | null;
}