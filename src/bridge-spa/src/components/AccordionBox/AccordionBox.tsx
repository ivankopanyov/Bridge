import { useState, FC, PropsWithChildren } from 'react';
import { Accordion } from '@mui/material';
import { DataObject, ErrorOutline } from '@mui/icons-material';
import { Text, AccordionBody, AccordionHeader } from '..';
import './AccordionBox.scss';

interface AccordionBoxProps {
    title?: string;
    fail?: boolean;
    expanded?: boolean;
    onChange?: (expanded: boolean) => void; 
}

const AccordionBox: FC<Readonly<PropsWithChildren<AccordionBoxProps>>> = ({ title, fail, expanded, onChange, children }) => {
    const [defaultExpanded, setDefaultExpanded] = useState(false);

    const onChangeExpanded = (value: boolean) => {
        onChange && onChange(value);
        setDefaultExpanded(value);
    };

    return (
        <Accordion
            className={`accordion-box ${ fail ? 'accordion-box-error' : 'accordion-box-normal' }`}
            expanded={expanded ?? defaultExpanded}
            onChange={(_e, s) => onChangeExpanded(s)}
        >
            <AccordionHeader>
                <div className="accordion-box-header">
                    {
                        fail
                            ? <ErrorOutline className="accordion-box-icon accordion-box-icon-error" />
                            : <DataObject className="accordion-box-icon accordion-box-icon-normal" />
                    }
                    <Text>{ title }</Text>
                </div>
            </AccordionHeader>
            <AccordionBody indent>
                { children }
            </AccordionBody>
        </Accordion>
    );
};

export default AccordionBox;