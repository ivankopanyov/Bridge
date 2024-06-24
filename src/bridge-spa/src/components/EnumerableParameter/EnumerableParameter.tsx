import { FC, PropsWithChildren, useState } from 'react';
import { IconButton, Accordion } from '@mui/material';
import { PlaylistAdd } from '@mui/icons-material';
import { AccordionBody, AccordionHeader } from '..';
import ParameterHeader from '../ParameterHeader/ParameterHeader';
import './EnumerableParameter.scss';

interface EnumerableParameterProps {
    title: string;
    editMode?: boolean;
    icon: JSX.Element;
    onClick: () => void;
}

const EnumerableParameter: FC<Readonly<PropsWithChildren<EnumerableParameterProps>>> = ({
    title, editMode, icon, onClick, children
}) => {
    const [expanded, setExpanded] = useState(false);

    const onAddClick = () => {
        setExpanded(true);
        onClick();
    };

    return (
        <div className="enumerable-parameter-container">
            {
                editMode && 
                    <IconButton className="enumerable-parameter-icon-button" onClick={onAddClick}>
                        <PlaylistAdd />
                    </IconButton>
            }
            <div className="enumerable-parameter-accordion-container">
                <Accordion expanded={expanded} onChange={(_e, s) => setExpanded(s)}>
                    <AccordionHeader>
                        <div className="enumerable-parameter-header-container">
                            { !editMode && icon }
                            <ParameterHeader name={title} />
                        </div>
                    </AccordionHeader>
                    <AccordionBody indent={!editMode}>{ children }</AccordionBody>
                </Accordion>
            </div>
        </div>
    );
};

export default EnumerableParameter;