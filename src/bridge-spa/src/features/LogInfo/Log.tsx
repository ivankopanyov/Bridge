import { useState, FC, useEffect } from 'react';
import { Accordion } from '@mui/material';
import { Done, Close } from '@mui/icons-material'
import { LogInfo } from '../LogList/data';
import { useAppDispatch } from '../../redux/hooks';
import { useLoopRequest } from '../../hooks';
import { AccordionBody, AccordionHeader, Text } from '../../components';
import { Loading } from '../../components';
import { getLog } from '../LogList/LogListStore';
import Error from '../../components/Error/Error';
import AccordionBox from '../../components/AccordionBox/AccordionBox';
import './Log.scss';
 
interface LogProps {
    log: LogInfo;
}

const Log: FC<Readonly<LogProps>> = ({ log }) => {
    const dispatch = useAppDispatch();
    const [expanded, setExpanded] = useState<boolean>(false);
    const loopRequest = useLoopRequest(async () => {
        const result = await dispatch(getLog({
            taskId: log.taskId,
            id: log.id
        }));
        return result.meta.requestStatus === 'fulfilled';
    });

    useEffect(() => {
        if (expanded && log.loading !== false) {
            loopRequest.start();
        } else if (!expanded) {
            loopRequest.stop();
        }
    }, [expanded]);

    useEffect(() => {
        return(() => {
            loopRequest.stop();
        });
    }, []);
    
    return (
        <Accordion expanded={expanded} onChange={(_e, s) => setExpanded(s)}>
            <AccordionHeader>
                <div className="log-header">
                    <div className="log-indent-right">
                        {
                            log.isError
                                ? <Close className="log-icon-fail" />
                                : <Done className="log-icon-success" />
                        }
                    </div>
                    <div>
                        <div className="log-header-name">
                            <Text>{ log.dateTime.display() }</Text>
                            {
                                log.handlerName &&
                                    <div className="log-handler log-indent-left">
                                        <Text>{ log.handlerName }</Text>
                                    </div>
                            }
                        </div>
                        {
                            log.message &&
                                <Text assignment="description" multiline>{ log.message }</Text>
                        }
                    </div>
                </div>
            </AccordionHeader>
            {
                !log.data
                    ? <AccordionBody indent>
                        { log.loading && <Text assignment="error" multiline>{ log.error }</Text> }
                        <Loading />
                    </AccordionBody>
                    : <AccordionBody indent>
                        {
                            (log.data?.error || log.data?.stackTrace) &&
                                <div className="log-indent-bottom">
                                    <Error error={log.data?.error} stackTrace={log.data?.stackTrace}/>
                                </div>
                        }
                        {
                            log.data?.inputObjectJson &&
                                <div className="log-indent-bottom">
                                    <AccordionBox title="Input Object">
                                        <Text multiline>{ log.data?.inputObjectJson }</Text>
                                    </AccordionBox>
                                </div>
                        }
                    </AccordionBody>
            }
        </Accordion>
    );
};

export default Log;