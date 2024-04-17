import { FC, PropsWithChildren } from 'react';
import { AccordionDetails } from '@mui/material';
import './AccordionBody.scss'

interface AccordionBodyProps {
    indent?: boolean;
}

export const AccordionBody: FC<Readonly<PropsWithChildren<AccordionBodyProps>>> = ({ indent, children }) => {
    return (
        <AccordionDetails className={`accordion-body ${indent && 'accordion-body-indent'}`} >
            { children }
        </AccordionDetails>
    );
};

export default AccordionBody;