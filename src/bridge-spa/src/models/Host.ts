import ServiceInfo from "./ServiceInfo";

export default interface Host {
    name: string;
    services: ServiceInfo[];
}