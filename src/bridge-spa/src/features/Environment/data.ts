import { Parameters } from "../ParameterList/data";

export interface Environment {
    loading: boolean;
    error?: string;
    parameters: Parameters;
}