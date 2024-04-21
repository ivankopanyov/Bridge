import { useState, FC } from 'react';
import { Accordion, Box } from '@mui/material';
import { CreditScore, CreditCard, CreditCardOff, HowToReg, Person, PersonOff, Done, Sync, ErrorOutline, HelpOutline } from '@mui/icons-material'
import { TaskInfo } from '../LogList/data';
import { AccordionBody, AccordionHeader, Text } from '../../components';
import Log from '../Log/Log';
import { toDisplayDateTime } from '../../utils/mapper';
import './Task.scss';
 
interface TaskProps {
    task: TaskInfo;
}

const Task: FC<Readonly<TaskProps>> = ({ task }) => {
    const [expanded, setExpanded] = useState<boolean>(false);
    
    return (
        <Accordion expanded={expanded} onChange={(e, s) => setExpanded(s)}>
            <AccordionHeader>
                <Box className="task-header">
                    <Box className="task-indent-right">
                        { 
                            task.queueName === 'RESV' && (task.status === 'ERROR' || task.status === 'CRITICAL') && 
                                <PersonOff className='task-icon-fail' />
                        }
                        {
                            task.queueName === 'RESV' && task.status === 'SUCCESS' && !task.isEnd && 
                                <Person className='task-icon' />
                        }
                        {
                            task.queueName === 'RESV' && task.status === 'SUCCESS' && task.isEnd &&
                                <HowToReg className='task-icon-success' />
                        }
                        {
                            task.queueName === 'POST' && (task.status === 'ERROR' || task.status === 'CRITICAL') &&
                                <CreditCardOff className='task-icon-fail' />
                        }
                        {
                            task.queueName === 'POST' && task.status === 'SUCCESS' && !task.isEnd &&
                                <CreditCard className='task-icon' />
                        }
                        {
                            task.queueName === 'POST' && task.status === 'SUCCESS' && task.isEnd &&
                                <CreditScore className='task-icon-success' />
                        }
                        {
                            task.queueName !== 'RESV' && task.queueName !== 'POST' && (task.status === 'ERROR' || task.status === 'CRITICAL') &&
                                <ErrorOutline className='task-icon-fail' />
                        }
                        {
                            task.queueName !== 'RESV' && task.queueName !== 'POST' && task.status === 'SUCCESS' && !task.isEnd &&
                                <Sync className='task-icon' />
                        }
                        {
                            task.queueName !== 'RESV' && task.queueName !== 'POST' && task.status === 'SUCCESS' && task.isEnd &&
                                <Done className='task-icon-success' />
                        }
                        { task.status === 'UNKNOWN' && <HelpOutline className='task-icon' /> }
                    </Box>
                    <Text full secondary>
                        { toDisplayDateTime(task.dateTime) }
                    </Text>
                    {
                        !expanded && task.handlerName &&
                            <Box className="task-handler task-indent-left">
                                <Text full>{ task.handlerName }</Text>
                            </Box> 
                    }
                    {
                        !expanded && task.description &&
                            <Box className="task-indent-left">
                                <Text secondary>{ task.description }</Text>
                            </Box> 
                    }
                </Box>
            </AccordionHeader>
            <AccordionBody indent>
                {
                    task.logs.map((log, index) => <Log key={index} log={log} />)
                }
            </AccordionBody>
        </Accordion>
    );
};

export default Task;