import Button from "@mui/material/Button";
import MarginProps from "./MarginProps";
import CircularProgress from "@mui/material/CircularProgress";

interface ButtonPropertyProps extends MarginProps {
    label: string;
    onClick: () => void;
    disabled?: boolean;
}

const ButtonProperty: React.FC<ButtonPropertyProps> = (props: ButtonPropertyProps) => {
    return (
        <div
            style={{
                display: 'flex',
                justifyContent: 'center',
                width: '100%',
                marginTop: props.mt ? props.mt + "px" : props.mt,
                marginBottom: props.mb ? props.mb + "px" : props.mb,
                marginLeft: props.ml ? props.ml + "px" : props.ml,
                marginRight: props.mr ? props.mr + "px" : props.mr
            }}>
            <Button
                onClick={props.onClick}
                disabled={props.disabled}>
                { !props.disabled ? props.label : <CircularProgress size='25px' /> }
            </Button>
        </div>
    );
};

export default ButtonProperty;