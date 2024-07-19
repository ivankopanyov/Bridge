import { Parameters } from "../ParameterList/data";

export interface ServiceState {
  isActive: boolean;
  error?: string;
  stackTrace?: string;
}

export interface SimpleServiceInfo {
  hostName: string;
  name: string;
  parameters: Parameters;
}

export interface ServiceInfo extends SimpleServiceInfo {
  state?: ServiceState;
  timeoutId?: NodeJS.Timeout;
  updateError?: string;
  loading: boolean;
}

export interface HostInfo {
  name: string;
  services: ServiceInfo[];
  activeServiceCount: number;
  error: boolean;
}

export interface HostList {
  hosts: HostInfo[];
  serviceCount: number;
  activeServiceCount: number;
  loading: boolean;
  error?: string;
  auth: boolean;
}
