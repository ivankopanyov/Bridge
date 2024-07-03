import { useState, FC } from 'react';
import { produce } from 'immer';
import { Button, TextField } from '@mui/material';
import { Save, Undo, Edit, EditOff, Menu, List, ChecklistRtl, RestartAlt, DeleteForever } from '@mui/icons-material';
import { Checkbox, EnumerableParameterItem, Text } from '../../components';
import { Parameters } from './data';
import Error from '../../components/Error/Error';
import ParameterHeader from '../../components/ParameterHeader/ParameterHeader';
import EnumerableParameter from '../../components/EnumerableParameter/EnumerableParameter';
import './ParameterList.scss';

interface ParameterListProps {
    parameters: Parameters;
    modifiedParameters: Parameters;
    disable: boolean;
    error?: string;
    stackTrace?: string;
    setModifiedParameters: (parameters: Parameters) => void;
    onSave: (parameters: Parameters) => Promise<void>;
    onReload?: () => void;
    onDelete?: () => void;
}

export const ParameterList: FC<Readonly<ParameterListProps>> = ({
    parameters, modifiedParameters, disable, error, stackTrace, setModifiedParameters, onSave, onReload, onDelete 
}) => {
    const [editMode, setEditMode] = useState(false);
    const disabled = !editMode || disable;
    const showButtons = parameters.booleanParameters.length > 0
        || parameters.stringParameters.length > 0
        || parameters.listParameters.length > 0
        || parameters.booleanMapParameters.length > 0
        || parameters.stringMapParameters.length > 0;
    
    const onSaveClick = async () => {
        const parameters = produce(modifiedParameters, (draftState) => {
            draftState.listParameters.forEach(parameter => parameter.value = parameter.value.filter(i => i.trim() !== ''));
            draftState.booleanMapParameters.forEach(parameter => parameter.value = parameter.value.filter(i => i.key.trim() !== ''));
            draftState.stringMapParameters.forEach(parameter => parameter.value = parameter.value.filter(i => i.key.trim() !== ''));
        });
        setModifiedParameters(parameters);
        setEditMode(false);
        await onSave(parameters);
    };

    const onBooleanParameterChanged = (index: number, value: boolean) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.booleanParameters[index].value = value;
        }));

    const onStringParameterChanged = (index: number, value: string) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.stringParameters[index].value = value;
        }));
        
    const addListParameterItem = (index: number) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.listParameters[index].value.push('');
        }));
        
    const deleteListParameterItem = (index: number, itemImdex: number) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.listParameters[index].value.splice(itemImdex, 1);
        }));
    
    const onListParameterItemChanged = (index: number, itemImdex: number, value: string) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.listParameters[index].value[itemImdex] = value;
        }));
    
    const addBooleanMapParameterItem = (index: number) => 
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.booleanMapParameters[index].value.push({ key: '', value: false });
        }));
        
    const deleteBooleanMapParameterItem = (index: number, itemImdex: number) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.booleanMapParameters[index].value.splice(itemImdex, 1);
        }));

    const onKeyBooleanMapParameterItemChanged = (index: number, itemIndex: number, value: string) => 
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.booleanMapParameters[index].value[itemIndex].key = value;
        }));

    const onValueBooleanMapParameterItemChanged = (index: number, itemIndex: number, value: boolean) => 
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.booleanMapParameters[index].value[itemIndex].value = value;
        }));
    
    const addStringMapParameterItem = (index: number) => 
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.stringMapParameters[index].value.push({ key: '', value: '' });
        }));
        
    const deleteStringMapParameterItem = (index: number, itemImdex: number) =>
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.stringMapParameters[index].value.splice(itemImdex, 1);
        }));

    const onKeyStringMapParameterItemChanged = (index: number, itemIndex: number, value: string) => 
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.stringMapParameters[index].value[itemIndex].key = value;
        }));

    const onValueStringMapParameterItemChanged = (index: number, itemIndex: number, value: string) => 
        setModifiedParameters(produce(modifiedParameters, (draftState) => {
            draftState.stringMapParameters[index].value[itemIndex].value = value;
        }));

    return (
        <div>
            {
                showButtons && (editMode 
                    ?   <div className="parameter-list-button-container">
                            <Button className="parameter-list-button" onClick={onSaveClick} disabled={disable}>
                                <Save className="parameter-list-button-icon" />
                                <Text>Save</Text>
                            </Button>
                            <Button className="parameter-list-button" onClick={() => setModifiedParameters(parameters)} disabled={disable}>
                                <Undo className="parameter-list-button-icon" />
                                <Text>Reset</Text>
                            </Button>
                            <Button className="parameter-list-button" onClick={() => setEditMode(false)} disabled={disable}>
                                <EditOff className="parameter-list-button-icon" />
                                <Text>Cancel</Text>
                            </Button>
                        </div>
                    :   <div className="parameter-list-button-container">
                            <Button className="parameter-list-button" onClick={() => setEditMode(true)} disabled={disable}>
                                <Edit className="parameter-list-button-icon" />
                                <Text>Edit</Text>
                            </Button>
                            {
                                onReload &&
                                    <Button className="parameter-list-button" onClick={onReload} disabled={disable}>
                                        <RestartAlt className="parameter-list-button-icon" />
                                        <Text>Reload</Text>
                                    </Button>
                            }
                            {
                                onDelete &&
                                    <Button className="parameter-list-button" onClick={onDelete} disabled={disable}>
                                        <DeleteForever className="parameter-list-button-icon" />
                                        <Text>Delete</Text>
                                    </Button>
                            }
                        </div>)
            }
            { 
                (error || stackTrace) && 
                    <Error error={error} stackTrace={stackTrace}/>
            }
            {
                (editMode ? modifiedParameters : parameters).booleanParameters.length > 0 &&
                    <div className="parameter-list-bool-params-container">
                        {
                            (editMode ? modifiedParameters : parameters).booleanParameters.map((parameter, index) => 
                                <div key={index} className="parameter-list-bool-param">
                                    <Checkbox
                                        value={parameter.value}
                                        setValue={(value) => onBooleanParameterChanged(index, value)}
                                        disabled={disabled}
                                    />
                                    <ParameterHeader name={parameter.name} />
                                </div>)
                        }
                    </div>
            }
            {
                (editMode ? modifiedParameters : parameters).stringParameters.map((parameter, index) =>
                    <div key={index}>
                        <ParameterHeader name={parameter.name} />
                        <TextField
                            value={parameter.value}
                            onChange={e => onStringParameterChanged(index, e.target.value)}
                            disabled={disabled}
                            fullWidth
                            multiline
                        />
                    </div>)
            }
            {
                (editMode ? modifiedParameters : parameters).listParameters.map((parameter, index) =>
                    <EnumerableParameter
                        key={index}
                        title={parameter.name}
                        editMode={editMode}
                        icon={<Menu className="parameter-list-success-icon" />}
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
                (editMode ? modifiedParameters : parameters).booleanMapParameters.map((parameter, index) =>
                    <EnumerableParameter
                        key={index}
                        title={parameter.name}
                        editMode={editMode}
                        icon={<ChecklistRtl className="parameter-list-success-icon" />}
                        onClick={() => addBooleanMapParameterItem(index)}
                    >
                        {
                            parameter.value.map((item, i) =>
                                <EnumerableParameterItem
                                    editMode={editMode}
                                    onDeleteClick={() => deleteBooleanMapParameterItem(index, i)}
                                >
                                    <div className="parameter-list-boolean-parameter">
                                        <Checkbox
                                            value={item.value}
                                            setValue={value => onValueBooleanMapParameterItemChanged(index, i, value)}
                                            disabled={disabled}
                                            large
                                        />
                                        <TextField
                                            value={item.key}
                                            onChange={e => onKeyBooleanMapParameterItemChanged(index, i, e.target.value)}
                                            disabled={disabled}
                                            fullWidth
                                            multiline
                                        />
                                    </div>
                                </EnumerableParameterItem>)
                        }
                    </EnumerableParameter>)
            }
            {
                (editMode ? modifiedParameters : parameters).stringMapParameters.map((parameter, index) =>
                    <EnumerableParameter
                        key={index}
                        title={parameter.name}
                        editMode={editMode}
                        icon={<List className="parameter-list-success-icon" />}
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
                                        className="parameter-list-left-input"
                                        value={item.key}
                                        onChange={e => onKeyStringMapParameterItemChanged(index, i, e.target.value)}
                                        disabled={disabled}
                                        fullWidth
                                        multiline
                                    />
                                    <TextField
                                        className="parameter-list-right-input"
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
        </div>
    );
};

export default ParameterList;