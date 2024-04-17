import { FC, PropsWithChildren } from 'react';
import { AccordionSummary } from '@mui/material';
import { ExpandMore } from '@mui/icons-material';
import './AccordionHeader.scss';

export const AccordionHeader: FC<Readonly<PropsWithChildren>> = ({ children }) => {
    return(
        <AccordionSummary className="accordion-header"
            expandIcon={<ExpandMore className="accordion-header-expand-icon" />}
        >
            { children }
        </AccordionSummary>
    );
};

export default AccordionHeader;