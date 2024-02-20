import OptionsProperty from "../models/OptionsProperty";

export default interface SetOptionsDto {
    hostName: string;
    serviceName: string;
    options: OptionsProperty[];
}