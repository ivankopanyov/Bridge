import Component from "./Component";
import Text from "./Text";

interface ErrorViewProps {
    error?: string;
    stackTrace?: string;
    failColor: string;
    margin: number;
}

const ErrorView: React.FC<ErrorViewProps> = (props: ErrorViewProps) => {
    return (
        <Component
            title={props.error ?? props.stackTrace}
            openTitle='Error'
            titleColor={props.failColor}
            contentColor={props.failColor}
            mb={props.margin}>
            {props.error && 
                <Text>
                    {props.error}
                </Text>}
            {props.stackTrace && 
                <Component
                    title='Stack Trace'
                    titleColor='#9c3636'>
                    <Text>
                        {props.stackTrace}
                    </Text>
                </Component>}
        </Component>
    );
};

export default ErrorView;