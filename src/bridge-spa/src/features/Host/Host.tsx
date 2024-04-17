import { useState, FC } from 'react';
import { Accordion, Box } from '@mui/material';
import { Computer } from '@mui/icons-material';
import { HostInfo } from '../HostList/data';
import Service from '../Service/Service';
import { Text, AccordionBody, AccordionHeader } from '../../components';
import './Host.scss';
 
interface HostProps {
    host: HostInfo;
}

const Host: FC<Readonly<HostProps>> = ({ host }) => {
    const [expanded, setExpanded] = useState<boolean>(false);
    
    return (
        <Accordion expanded={expanded} onChange={(e, s) => setExpanded(s)}>
            <AccordionHeader>
                <Box className="host-container">
                    <Computer
                        className={`host-indent-right ${ host.services.length > host.activeServiceCount ? 'host-fail-icon' : 'host-success-icon' }`}
                    />
                    <Box className="host-indent-right">
                        <Text>{ host.name }</Text>
                    </Box>
                    <Text secondary>{`(${host.activeServiceCount}/${host.services.length})`}</Text>
                </Box>
            </AccordionHeader>
            <AccordionBody indent>
                {  host.services.map((service, index) => <Service key={index} service={service} />) }
            </AccordionBody>
        </Accordion>
    );
};

export default Host;