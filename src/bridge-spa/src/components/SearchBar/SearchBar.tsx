import { FC } from 'react';
import { IconButton, InputAdornment, TextField } from '@mui/material';
import { Cancel, Search, Tune } from '@mui/icons-material';
import './SearchBar.scss';

interface SearchBarProps {
    value: string;
    onChange: (value: string) => void;
    fixed?: boolean;
}

export const SearchBar: FC<Readonly<SearchBarProps>> = ({ value, onChange, fixed }) => {
    return (
        <TextField
            className={`search-bar ${fixed && 'search-bar-fixed'}`}
            value={value}
            onChange={e => onChange(e.target.value)}
            fullWidth={!fixed}
            InputProps={{
                startAdornment:
                    <InputAdornment className="search-bar-adornment-left" position="end">
                        <Search className="search-bar-icon search-bar-icon-search" />
                    </InputAdornment>,
                endAdornment: 
                    <InputAdornment className="search-bar-adornment-right" position="start">
                        <IconButton className="search-bar-icon-button">
                            <Tune className="search-bar-icon" />
                        </IconButton>
                        {
                            value.length > 0 &&
                                <IconButton
                                    className="search-bar-icon-button"
                                    onClick={() => onChange('')}
                                >
                                    <Cancel className="search-bar-icon" />
                                </IconButton> 
                        }
                    </InputAdornment>
            }}
        />
    );
};

export default SearchBar;