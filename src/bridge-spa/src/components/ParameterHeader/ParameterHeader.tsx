import { FC } from "react";
import { Text } from "..";
import "./ParameterHeader.scss";

interface ParameterHeaderProps {
    name: string;
}

const ParameterHeader: FC<Readonly<ParameterHeaderProps>> = ({ name }) => {

    const def = (name: string) => { return {
        name: fixName(name),
        description: undefined
    }};

    const fixName = (name: string) => name.length === 0 ? name
        : `${name.charAt(0).toUpperCase()}${name.slice(1)}`.split(/(?=[A-Z])/).join(' ');

    const getParameterName = (): {
        name: string;
        description?: string;
    } => {
        if (name.length === 0 || name.charAt(name.length - 1) !== ')')
            return def(name);

        const index = name.indexOf(' (');
        return index < 0 ? def(name) : {
            name: fixName(name.substring(0, index)),
            description: name.substring(index + 2, name.length - 1)
        };
    };

    const parameterName = getParameterName();

    return (
        <div className="parameter-header">
            <Text>{ parameterName.name }</Text>
            {
                parameterName.description &&
                    <Text assignment="description" multiline>
                        {parameterName.description}
                    </Text>
            }
        </div>
    );
};

export default ParameterHeader;