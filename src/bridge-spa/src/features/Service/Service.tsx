import { useState, FC } from 'react';
import { produce } from 'immer';
import { Accordion, Box, Button, CircularProgress, TextField } from '@mui/material';
import { Link, LinkOff, Save, RestartAlt, Edit, EditOff, Menu, List, ChecklistRtl } from '@mui/icons-material';
import { useAppDispatch } from '../../redux/hooks';
import { updateService } from '../HostList/HostListStore';
import { ServiceInfo } from '../HostList/data';
import { AccordionBody, AccordionHeader, Checkbox, EnumerableParameterItem, Text } from '../../components';
import Error from '../../components/Error/Error';
import EnumerableParameter from '../../components/EnumerableParameter/EnumerableParameter';
import './Service.scss';

interface ServiceProps {
    service: ServiceInfo;
}

const Service: FC<Readonly<ServiceProps>> = ({ service }) => {
    const dispatch = useAppDispatch();
    const [expanded, setExpanded] = useState(false);
    const [modifiedService, setModifiedService] = useState(service);
    const [editMode, setEditMode] = useState(false);
    const disabled = !editMode || service.loading;
    
    const onSaveClick = () => {
        const service = produce(modifiedService, (draftState) => {
            draftState.listParameters.forEach(parameter => parameter.value = parameter.value.filter(i => i.trim() !== ''));
            draftState.booleanMapParameters.forEach(parameter => parameter.value = parameter.value.filter(i => i.key.trim() !== ''));
            draftState.stringMapParameters.forEach(parameter => parameter.value = parameter.value.filter(i => i.key.trim() !== ''));
        });
        setModifiedService(service);
        dispatch(updateService(service));
        setEditMode(false);
    };

    const onResetClick = () => setModifiedService(service);

    const onCancelClick = () => {
        setModifiedService(service);
        setEditMode(false);
    };

    const onEditClick = () => setEditMode(true);

    const onBooleanParameterChanged = (index: number, value: boolean) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.booleanParameters[index].value = value;
        }));

    const onStringParameterChanged = (index: number, value: string) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.stringParameters[index].value = value;
        }));
        
    const addListParameterItem = (index: number) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.listParameters[index].value.push('');
        }));
        
    const deleteListParameterItem = (index: number, itemImdex: number) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.listParameters[index].value.splice(itemImdex, 1);
        }));
    
    const onListParameterItemChanged = (index: number, itemImdex: number, value: string) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.listParameters[index].value[itemImdex] = value;
        }));
    
    const addBooleanMapParameterItem = (index: number) => 
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.booleanMapParameters[index].value.push({ key: '', value: false });
        }));
        
    const deleteBooleanMapParameterItem = (index: number, itemImdex: number) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.booleanMapParameters[index].value.splice(itemImdex, 1);
        }));

    const onKeyBooleanMapParameterItemChanged = (index: number, itemIndex: number, value: string) => 
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.booleanMapParameters[index].value[itemIndex].key = value;
        }));

    const onValueBooleanMapParameterItemChanged = (index: number, itemIndex: number, value: boolean) => 
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.booleanMapParameters[index].value[itemIndex].value = value;
        }));
    
    const addStringMapParameterItem = (index: number) => 
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.stringMapParameters[index].value.push({ key: '', value: '' });
        }));
        
    const deleteStringMapParameterItem = (index: number, itemImdex: number) =>
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.stringMapParameters[index].value.splice(itemImdex, 1);
        }));

    const onKeyStringMapParameterItemChanged = (index: number, itemIndex: number, value: string) => 
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.stringMapParameters[index].value[itemIndex].key = value;
        }));

    const onValueStringMapParameterItemChanged = (index: number, itemIndex: number, value: string) => 
        setModifiedService(produce(modifiedService, (draftState) => {
            draftState.stringMapParameters[index].value[itemIndex].value = value;
        }));
    
    return (
        <Accordion expanded={expanded} onChange={(_e, s) => setExpanded(s)}>
            <AccordionHeader>
                <Box className="service-header-container">
                    {
                        service.loading
                            ? <CircularProgress className="service-progress" />
                            : (service.isActive
                                ? <Link className="service-success-icon" />
                                : <LinkOff className="service-fail-icon" />)
                    }
                    <Text>{service.name}</Text>
                </Box>
            </AccordionHeader>
            <AccordionBody indent>
                {
                    editMode 
                        ?   <Box className="service-button-container">
                                <Button className="service-button" onClick={onSaveClick} disabled={service.loading}>
                                    <Save className="service-button-icon" />
                                    <Text>Save</Text>
                                </Button>
                                <Button className="service-button" onClick={onResetClick} disabled={service.loading}>
                                    <RestartAlt className="service-button-icon" />
                                    <Text>Reset</Text>
                                </Button>
                                <Button className="service-button" onClick={onCancelClick} disabled={service.loading}>
                                    <EditOff className="service-button-icon" />
                                    <Text>Cancel</Text>
                                </Button>
                            </Box>
                        :   <Box className="service-button-container">
                                <Button className="service-button" onClick={onEditClick} disabled={service.loading}>
                                    <Edit className="service-button-icon" />
                                    <Text>Edit</Text>
                                </Button>
                            </Box>
                }
                { (service.error || service.stackTrace) && <Error error={service.error} stackTrace={service.stackTrace}/> }
                {
                    (editMode ? modifiedService : service).booleanParameters.length > 0 &&
                        <Box className="service-bool-params-container">
                            {
                                (editMode ? modifiedService : service).booleanParameters.map((parameter, index) => 
                                    <Box key={index} className="service-bool-param">
                                        <Box className="service-checkbox">
                                            <Checkbox
                                                value={parameter.value}
                                                setValue={(value) => onBooleanParameterChanged(index, value)}
                                                disabled={disabled}
                                            />
                                        </Box>
                                        <Text>{parameter.name}</Text>
                                    </Box>)
                            }
                        </Box>
                }
                {
                    (editMode ? modifiedService : service).stringParameters.map((parameter, index) =>
                        <Box key={index}>
                            <Text>{parameter.name}</Text>
                            <TextField
                                value={parameter.value}
                                onChange={e => onStringParameterChanged(index, e.target.value)}
                                disabled={disabled}
                                fullWidth
                                multiline
                            />
                        </Box>)
                }
                {
                    (editMode ? modifiedService : service).listParameters.map((parameter, index) =>
                        <EnumerableParameter
                            key={index}
                            title={parameter.name}
                            editMode={editMode}
                            icon={<Menu className="service-success-icon" />}
                            onClick={() => addListParameterItem(index)}
                        >
                            {
                                parameter.value.map((item, i) =>
                                    <EnumerableParameterItem
                                        key={i} 
                                        editMode={editMode}
                                        onDeleteClick={() => deleteListParameterItem(index, i)}
                                    >
                                        <TextField
                                            value={item}
                                            onChange={e => onListParameterItemChanged(index, i, e.target.value)}
                                            disabled={disabled}
                                            fullWidth
                                            multiline
                                        />
                                    </EnumerableParameterItem>)
                            }
                        </EnumerableParameter>)
                }
                {
                    (editMode ? modifiedService : service).booleanMapParameters.map((parameter, index) =>
                        <EnumerableParameter
                            key={index}
                            title={parameter.name}
                            editMode={editMode}
                            icon={<ChecklistRtl className="service-success-icon" />}
                            onClick={() => addBooleanMapParameterItem(index)}
                        >
                            {
                                parameter.value.map((item, i) =>
                                    <EnumerableParameterItem
                                        editMode={editMode}
                                        onDeleteClick={() => deleteBooleanMapParameterItem(index, i)}
                                    >
                                        <Box display="flex" alignItems="center" flexGrow={1}>
                                            <TextField
                                                value={item.key}
                                                onChange={e => onKeyBooleanMapParameterItemChanged(index, i, e.target.value)}
                                                disabled={disabled}
                                                fullWidth
                                                multiline
                                            />
                                            <Box className="service-checkbox-large">
                                                <Checkbox
                                                    value={item.value}
                                                    setValue={value => onValueBooleanMapParameterItemChanged(index, i, value)}
                                                    disabled={disabled}
                                                    large
                                                />
                                            </Box>
                                        </Box>
                                    </EnumerableParameterItem>)
                            }
                        </EnumerableParameter>)
                }
                {
                    (editMode ? modifiedService : service).stringMapParameters.map((parameter, index) =>
                        <EnumerableParameter
                            key={index}
                            title={parameter.name}
                            editMode={editMode}
                            icon={<List className="service-success-icon" />}
                            onClick={() => addStringMapParameterItem(index)}
                        >
                            {
                                parameter.value.map((item, i) =>
                                    <EnumerableParameterItem 
                                        key={i}
                                        editMode={editMode}
                                        onDeleteClick={() => deleteStringMapParameterItem(index, i)}
                                    >
                                        <TextField
                                            className="service-left-input"
                                            value={item.key}
                                            onChange={e => onKeyStringMapParameterItemChanged(index, i, e.target.value)}
                                            disabled={disabled}
                                            fullWidth
                                            multiline
                                        />
                                        <TextField
                                            className="service-right-input"
                                            value={item.value}
                                            onChange={e => onValueStringMapParameterItemChanged(index, i, e.target.value)}
                                            disabled={disabled}
                                            fullWidth
                                            multiline
                                        />
                                    </EnumerableParameterItem>)
                            }
                        </EnumerableParameter>)
                }
            </AccordionBody>
        </Accordion>
    );
};

export default Service;