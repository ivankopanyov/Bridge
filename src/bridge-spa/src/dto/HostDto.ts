import ServiceDto from "./ServiceDto";

export default interface HostDto {
    name: string;
    services: ServiceDto[];
}