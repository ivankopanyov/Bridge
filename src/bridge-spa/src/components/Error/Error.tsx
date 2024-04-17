import { useState, FC } from 'react';
import { Accordion, Box } from '@mui/material';
import { ErrorOutline } from '@mui/icons-material';
import { Text, AccordionBody, AccordionHeader } from '..';
import './Error.scss';

interface ErrorProps {
    error?: string;
    stackTrace?: string;
}

export const Error: FC<Readonly<ErrorProps>> = ({ error, stackTrace }) => {
    const [errorExpanded, setErrorExpanded] = useState<boolean>(false);
    const [stackTraceExpanded, setStackTraceExpanded] = useState<boolean>(false);

    return (
        <Accordion className="error" expanded={errorExpanded} onChange={(_e, s) => setErrorExpanded(s)}>
            <AccordionHeader>
                <Box className="error-header">
                    <ErrorOutline className="error-icon" />
                    <Text>{ errorExpanded ? (error ? 'Error' : 'StackTrace') : (error ?? stackTrace) }</Text>
                </Box>
            </AccordionHeader>
            <AccordionBody indent>
                <Text multiline>{ error ? error : stackTrace }</Text>
                { 
                    (error && stackTrace) && 
                        <Accordion expanded={stackTraceExpanded} onChange={(_e, s) => setStackTraceExpanded(s)}>
                            <AccordionHeader>
                                <Box className="error-header">
                                    <ErrorOutline className="error-icon" />
                                    <Text>Stack Trace</Text>
                                </Box>
                            </AccordionHeader>
                            <AccordionBody indent>
                                <Text multiline>{ stackTrace }</Text>
                            </AccordionBody>
                        </Accordion>
                }
            </AccordionBody>
        </Accordion>
    );
};

export default Error;