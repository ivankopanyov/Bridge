import { Parameters } from "../ParameterList/data";

export interface Environment {
    auth: boolean;
    loading: boolean;
    error?: string;
    parameters: Parameters;
}