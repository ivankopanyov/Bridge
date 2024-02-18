import CheckboxProperty from "./CheckboxProperty";
import InputProperty from "./InputProperty";
import ArrayProperty from "./ArrayProperty";
import MapProperty from "./MapProperty";
import MarginProps from "./MarginProps";

interface FieldProps extends MarginProps {
    name: string;
    value: any;
    setValue: (value: any) => void;
    disabled?: boolean;
}
  
const Field: React.FC<FieldProps> = (props: FieldProps) => {
    const getType = (value: any): "boolean" | "string" | "array" | "map" => {
        let type = typeof value;
        if (type === "boolean")
            return "boolean";
        if (type === "object")
            return Array.isArray(value) ? "array" : "map";
        return "string";
    }
  
    const type = getType(props.value);
  
    return (
        <div
            style={{
                width: "100%"
            }}>
            { type === "boolean" && 
            <CheckboxProperty
                label={props.name}
                checked={Boolean(props.value)}
                onChange={props.setValue}
                mt={props.mt}
                mb={props.mb}
                ml={props.ml}
                mr={props.mr}
                disabled={props.disabled} /> }
            { type === "string" && 
            <InputProperty
                label={props.name}
                value={String(props.value)}
                onChange={props.setValue}
                mt={props.mt}
                mb={props.mb}
                ml={props.ml}
                mr={props.mr}
                disabled={props.disabled} /> }
            { type === "array" && 
            <ArrayProperty
                title={props.name}
                value={[...props.value]}
                setValue={props.setValue}
                mt={props.mt}
                mb={props.mb}
                ml={props.ml}
                mr={props.mr}
                disabled={props.disabled} /> }
            { type === "map" && 
            <MapProperty
                title={props.name}
                value={Object.keys(props.value).map((key, index) => { return {
                    name: key,
                    value: Object.values<string>(props.value)[index]
                }})}
                setValue={value => props.setValue(Object.fromEntries(value.map(i => [i.name, i.value])))}
                mt={props.mt}
                mb={props.mb}
                ml={props.ml}
                mr={props.mr}
                disabled={props.disabled} /> }
        </div>
    );
};

export default Field;