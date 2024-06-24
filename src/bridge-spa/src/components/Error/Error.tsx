import { useState, FC } from 'react';
import { Accordion } from '@mui/material';
import { ErrorOutline } from '@mui/icons-material';
import { Text, AccordionBody, AccordionHeader } from '..';
import AccordionBox from '../AccordionBox/AccordionBox';
import './Error.scss';

interface ErrorProps {
    error?: string;
    stackTrace?: string;
}

const Error: FC<Readonly<ErrorProps>> = ({ error, stackTrace }) => {
    const [errorExpanded, setErrorExpanded] = useState<boolean>(false);
    const [stackTraceExpanded, setStackTraceExpanded] = useState<boolean>(false);

    return (
        <AccordionBox
            title={ errorExpanded ? (error ? 'Error' : 'StackTrace') : (error ?? stackTrace) }
            expanded={errorExpanded}
            onChange={setErrorExpanded}
            fail
        >
            <Text multiline>{ error ? error : stackTrace }</Text>
            { 
                (error && stackTrace) && 
                    <Accordion expanded={stackTraceExpanded} onChange={(_e, s) => setStackTraceExpanded(s)}>
                        <AccordionHeader>
                            <div className="error-header">
                                <ErrorOutline className="error-icon" />
                                <Text>Stack Trace</Text>
                            </div>
                        </AccordionHeader>
                        <AccordionBody indent>
                            <Text multiline>{ stackTrace }</Text>
                        </AccordionBody>
                    </Accordion>
            }
        </AccordionBox>
    );
};

export default Error;