import { FC, PropsWithChildren, useState } from 'react';
import { Box, IconButton, Accordion } from '@mui/material';
import { PlaylistAdd } from '@mui/icons-material';
import { Text, AccordionBody, AccordionHeader } from '..';
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
        <Box className="enumerable-parameter-container">
            {
                editMode && 
                    <IconButton className="enumerable-parameter-icon-button" onClick={onAddClick}>
                        <PlaylistAdd />
                    </IconButton>
            }
            <Box className="enumerable-parameter-accordion-container">
                <Accordion expanded={expanded} onChange={(_e, s) => setExpanded(s)}>
                    <AccordionHeader>
                        <Box className="enumerable-parameter-header-container">
                            { !editMode && icon }
                            <Text>{title}</Text>
                        </Box>
                    </AccordionHeader>
                    <AccordionBody indent={!editMode}>{ children }</AccordionBody>
                </Accordion>
            </Box>
        </Box>
    );
};

export default EnumerableParameter;