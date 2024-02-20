import Service from "./Service";

export default interface Host {
    name: string;
    services: Service[];
}