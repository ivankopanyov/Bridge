import { FC, PropsWithChildren } from 'react';
import { IconButton } from '@mui/material';
import { DeleteForever } from '@mui/icons-material';
import './EnumerableParameterItem.scss';

interface EnumerableParameterItemProps {
    editMode: boolean
    onDeleteClick: () => void;
}

export const EnumerableParameterItem: FC<Readonly<PropsWithChildren<EnumerableParameterItemProps>>> = ({ editMode, onDeleteClick, children }) => {
    return (
        <div className="enumerable-parameter-item-container">
            { children }
            {
                editMode &&
                    <IconButton className="enumerable-parameter-item-icon-button" onClick={onDeleteClick} >
                        <DeleteForever className="enumerable-parameter-item-icon" />
                    </IconButton>
            }
        </div>
    );
};

export default EnumerableParameterItem;